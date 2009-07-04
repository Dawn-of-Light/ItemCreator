using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using ItemCreator.database;

namespace ItemCreator
{
    public partial class MainForm : Form
    {
        public System.Resources.ResourceManager Locales = null;
        
        static string preferencesFile = Application.StartupPath + "//preferences.xml";
        
        private bool itemSaved = true;
        private string itemFilename = "";

        private DataSet[] _bonusData = new DataSet[11];
        private DataSet[] bonusData
        {
            get { return _bonusData; }
            set { _bonusData = value; }
        }

        private MySqlConnection _mysqlConnection = null;
        public MySqlConnection mysqlConnection
        {
            get { return _mysqlConnection; }
            set { _mysqlConnection = value; }
        }
        public bool mysql_enabled = false;

        public MainForm()
        {
            //Locales
            this.Locales = new System.Resources.ResourceManager("ItemCreator.Resources.winFormStrings", typeof(MainForm).Assembly);
            
            SplashScreen splash = new SplashScreen();
            splash.Show();
            splash.updateState(Locales.GetString("splash_loading"), 0);

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            InitializeComponent();

            //Set language Menu
            this.setLanguagesMenu();

            //Hole alle Daten aus base.xml und lade sie in das From
            splash.updateState(Locales.GetString("splash_loading_xml"), 25);
            bool loadComboBoxesCheck = loadComboBoxes();
            //if (loadComboBoxesCheck == false) Application.ExitThread();

            splash.updateState(Locales.GetString("splash_loading_preferences"), 50);
            loadPreferences();

            splash.updateState(Locales.GetString("splash_checking_mysql_settings"), 75);
            setMysqlConnection();

            //Überprüfe nach neuen Verisonen wenn erwünscht
            if (basicRow.checkApplicationUpdates || basicRow.checkDatabaseUpdates)
            {
                splash.updateState(Locales.GetString("splash_checking_versions"), 85);

                updaterForm updater = new updaterForm(this);
                updater.checkVersions();
                if ((basicRow.checkApplicationUpdates && updater.IsNewApplicationVersionAvailable()) || (basicRow.checkDatabaseUpdates && updater.IsNewDatabaseUpdateAvailable()))
                {
                    //Message: New versions of Application or Databases are available!
                    MessageBox.Show(Locales.GetString("updater_new_versions_are_available"), Locales.GetString("updater_new_versions_are_available_title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                updater.Dispose();
            }

            splash.updateState(Locales.GetString("splash_starting"), 100);
            splash.Close();
            splash.Dispose();

            this.versionInformation.Text = "v" + Application.ProductVersion;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            newItem(null, null);
        }

        private bool loadComboBoxes()
        {
            //Prüfen ob die Datei existiert
            if (System.IO.File.Exists(Application.StartupPath + "//database/base.xml") == false)
            {
                MessageBox.Show(Locales.GetString("error_basefile_not_found"), Locales.GetString("error_messagebox_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                foreach (DataTable dataTable in this.baseXMLData.Tables) dataTable.BeginLoadData();
                this.baseXMLData.ReadXml(Application.StartupPath + "//database/base.xml");
                foreach (DataTable dataTable in this.baseXMLData.Tables) dataTable.EndLoadData();

                
                //Stats-Kategorien in eigene Tabellen speichern
                for (int i = 0; i < 11; i++)
                {
                    bonusData.SetValue(this.baseXMLData.Copy(), i);
                    foreach (DataRow row in bonusData[i].Tables["bonus"].Rows)
                    {
                        if (bonusData[i].Tables.Contains("stats_" + row["category"].ToString()) == false)
                        {
                            bonusData[i].Tables.Add("stats_" + row["category"].ToString());
                            bonusData[i].Tables["stats_" + row["category"].ToString()].Columns.Add("id");
                            bonusData[i].Tables["stats_" + row["category"].ToString()].Columns.Add("name");
                        }
                        
                        object[] values = new Object[2];
                        values.SetValue(row["id"], 0);
                        values.SetValue(row["name"], 1);
                        bonusData[i].Tables["stats_" + row["category"].ToString()].Rows.Add(values);
                    }

                    ComboBox control = (ComboBox)this.Controls.Find("effectCat" + (i+1), true)[0];
                    control.DataSource = bonusData[i].Tables["bonus_category"];
                    control.ValueMember = "name";
                    control.DisplayMember = "name";
                    control.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(Locales.GetString("error_reading_basefile"), Locales.GetString("error_messagebox_title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Preferences.MySQLRow _mysqlRow = null;
        private Preferences.BasicRow _basicRow = null;
        public Preferences.MySQLRow mysqlRow
        {
            get { return this._mysqlRow; }
            set { this._mysqlRow = value; }
        }
        public Preferences.BasicRow basicRow
        {
            get { return this._basicRow; }
            set { this._basicRow = value; }
        }
        private void loadPreferences()
        {
            Preferences preferences = new Preferences();
            if (System.IO.File.Exists(preferencesFile))
            {
                foreach (DataTable dataTable in preferences.Tables) dataTable.BeginLoadData();
                preferences.ReadXml(preferencesFile);
                foreach (DataTable dataTable in preferences.Tables) dataTable.EndLoadData();

                //Prüfen ob irgendwelche Datensätze DBNull enthalten, wenn ja, dann preferences Fenster öffnen
                bool checkPreferences = false;
                foreach (DataColumn column in preferences.MySQL.Columns)
                {
                    if (preferences.MySQL.Rows[0].IsNull(column.ColumnName)) checkPreferences = true;
                    //if (preferences.MySQL.Rows[0][column.ColumnName].GetType().ToString() == System.DBNull.Value.GetType().ToString()) checkPreferences = true;
                }

                foreach (DataColumn column in preferences.Basic.Columns)
                {
                    if (preferences.Basic.Rows[0].IsNull(column.ColumnName)) checkPreferences = true;
                    //if (preferences.Basic.Rows[0][column.ColumnName].GetType().ToString() == System.DBNull.Value.GetType().ToString()) checkPreferences = true;
                }

                if (checkPreferences == true)
                {
                    MessageBox.Show(Locales.GetString("preferences_new_options"));
                    preferencesToolStripMenuItem_Click(null, null);
                    return;
                }

            }
            else
            {
                Preferences.MySQLRow mysqlRow = preferences.MySQL.NewMySQLRow();
                preferences.MySQL.Rows.Add(mysqlRow);

                Preferences.BasicRow basicRow = preferences.Basic.NewBasicRow();
                preferences.Basic.Rows.Add(basicRow);

                preferences.WriteXml(preferencesFile);
                loadPreferences();
                return;
            }

            this.mysqlRow = (Preferences.MySQLRow)preferences.MySQL.Rows[0];
            this.basicRow = (Preferences.BasicRow)preferences.Basic.Rows[0];
        }

        private void selectStatsCategory(object sender, EventArgs e)
        {
            //Es wurde eine Stats-Kategorie ausgewählt
            ComboBox element = (ComboBox)sender;
            string selectedValue = Convert.ToString(element.SelectedValue);

            //ID des Stats
            int statId = Convert.ToInt32(element.Name.Substring(9));
            ComboBox statValues = (ComboBox)this.Controls.Find("item_effect" + statId, true)[0];
            statValues.DataSource = bonusData[statId-1].Tables["stats_" + selectedValue];
            statValues.DisplayMember = "name";
            statValues.ValueMember = "id";
        }

        /**
         * Bereitet ein Item zum speichern vor
         * */
        private void setItem()
        {
            if (this.item.ItemTemplate.Count > 0)
            {
                //Selectierte Klassen eintragen                
                string allowedClasses = "";
                foreach (DataRowView row in this.item_classes.SelectedItems)
                {
                    if (allowedClasses == "") allowedClasses = row.Row["id"].ToString();
                    else allowedClasses += ";" + row.Row["id"].ToString();
                }
                this.item.ItemTemplate.Rows[0]["AllowedClasses"] = allowedClasses;

                //Selektierte Stats eintragen
                for (int i = 1; i <= 11; i++)
                {
                    ComboBox tempBox = (ComboBox)Controls.Find("item_effect" + i.ToString(), true)[0];

                    object selectedValue = (tempBox.SelectedValue != null) ? tempBox.SelectedValue : DBNull.Value;

                    if (i == 11) this.item.ItemTemplate.Rows[0]["ExtraBonusType"] = selectedValue;
                    else this.item.ItemTemplate.Rows[0]["Bonus" + i.ToString() + "Type"] = selectedValue;
                }

                item.AcceptChanges();
            }
        }

        private void loadItemValues()
        {
            //Klassen wählen
            //serialized String
            this.item_classes.SelectedIndices.Clear();

            string classes = (string)item.ItemTemplate.Rows[0]["AllowedClasses"];
            //MessageBox.Show("classes: " + classes);
            string[] classes_split = classes.Split(Convert.ToChar(";"));

            ListBox.SelectedObjectCollection selectedClasses = new ListBox.SelectedObjectCollection(item_classes);
            for (int i = 0; i < this.item_classes.Items.Count; i++)
            {
                DataRowView row = (DataRowView)this.item_classes.Items[i];
                for (int n = 0; n < classes_split.Length; n++)
                {
                    //MessageBox.Show("vergleiche " + classes_split[n] + " mit " + row.Row["id"]);
                    if (classes_split[n] == row.Row["id"].ToString())
                    {
                        item_classes.SetSelected(i, true);
                        //MessageBox.Show("selektiere " + classes_split[n]);
                    }
                }
            }

            //Stats categorien laden und Wert selektieren
            for (int i = 1; i <= 11; i++)
            {
                object bonusTypeObj;
                int bonusType;
                if (i == 11) bonusTypeObj = this.item.ItemTemplate.Rows[0]["ExtraBonusType"];
                else bonusTypeObj = this.item.ItemTemplate.Rows[0]["Bonus" + i.ToString() + "Type"];

                if (bonusTypeObj.ToString() != "")
                {
                    bonusType = (int)bonusTypeObj;
                    DataRow cat = this.baseXMLData.Tables["bonus"].Rows.Find(bonusType);

                    ComboBox control = (ComboBox)this.Controls.Find("effectCat" + (i), true)[0];
                    control.SelectedValue = cat["category"];

                    ComboBox box = (ComboBox)this.Controls.Find("item_effect" + (i), true)[0];
                    box.SelectedValue = cat["id"];
                }
                else
                {
                    ComboBox control = (ComboBox)this.Controls.Find("effectCat" + (i), true)[0];
                    control.SelectedIndex = 0;
                }
            }

            getLootTemplatesOfItem();
        }

        private void newItem(object sender, EventArgs e)
        {
            if (item.ItemTemplate.Count > 0) item.ItemTemplate.Clear();
            ItemTemplates.ItemTemplateRow itemTemplateRow = item.ItemTemplate.NewItemTemplateRow();
            item.ItemTemplate.Rows.Add(itemTemplateRow);
            
            loadItemValues();

            // New Item - Merecs ItemCreator for Dawn of Light
            this.Text = Locales.GetString("new_item") + " - " + Locales.GetString("application_name");
            itemFilename = "";
            itemSaved = true;
        }
        
        private void itemChanged(object sender, EventArgs e)
        {
            if (itemFilename != "")
            {
                // * - Merecs ItemCreator for Dawn of Light
                this.Text = itemFilename + "* - " + Locales.GetString("application_name");
            }
            else
            {
                // New Item* - Merecs ItemCreator for Dawn of Light
                this.Text = Locales.GetString("new_item") + "* - " + Locales.GetString("application_name");
            }
            itemSaved = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemSaved == false && this.basicRow.askSaveToFile == true)
            {
                DialogResult dialog;
                
                if (this.itemFilename != "")
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(itemFilename);
                    string basename = fileInfo.Name;

                    // Message: Save FILENAME?
                    // Title: save Item
                    string message = String.Format(Locales.GetString("save_file_with_filename"), basename);
                    dialog = MessageBox.Show(message, Locales.GetString("save_item_title"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                else
                {
                    //Message: Would you like to save the Item?
                    //Title: save Item
                    dialog = MessageBox.Show(Locales.GetString("save_item_ask"), Locales.GetString("save_item_title"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                if (dialog == DialogResult.Yes) saveItem(null, null);
                else if (dialog == DialogResult.No) return;
                else e.Cancel = true;
            }
        }

        #region Menu actions

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preferencesForm preferencesForm = new preferencesForm(this, preferencesFile);
            DialogResult result = preferencesForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                preferencesForm.preferences.WriteXml(preferencesFile);
            }
            preferencesForm.Dispose();

            loadPreferences();
            setMysqlConnection();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Save and Open Item

        private void saveItem(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Application.StartupPath + "//Items"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "//Items");
            }

            setItem();

            if (itemSaved == false && itemFilename == "")
            {
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    itemFilename = saveFileDialog.FileName;
                    item.WriteXml(itemFilename);
                    itemSaved = true;

                    this.Text = itemFilename + " - " + Locales.GetString("application_name");
                }
            }
            else if (itemFilename != "")
            {
                item.WriteXml(itemFilename);
                this.Text = itemFilename + " - " + Locales.GetString("application_name");
                itemSaved = true;
            }
        }

        private void saveItemAs(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Application.StartupPath + "//Items"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "//Items");
            }

            setItem();

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                itemFilename = saveFileDialog.FileName;
                item.WriteXml(itemFilename);
                itemSaved = true;

                this.Text = itemFilename + " - " + Locales.GetString("application_name");
            }
        }

        private void openItem(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Application.StartupPath + "//Items"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "//Items");
            }

            if (itemSaved == false && this.basicRow.askSaveToFile == true)
            {
                DialogResult dialog = MessageBox.Show(Locales.GetString("save_item_ask"), Locales.GetString("save_item_title"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                //User klickt ja
                if (dialog == DialogResult.Yes)
                {
                    saveItem(null, null);
                }
                else if (dialog == DialogResult.Cancel)
                {
                    return;
                }
            }

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                itemFilename = openFileDialog.FileName;
                this.item.Clear();
                this.item.ReadXml(itemFilename);
                loadItemValues();

                this.Text = itemFilename + " - " + Locales.GetString("application_name");
                itemSaved = true;
            }
        }

        private void selectItemFromDatabase(object sender, EventArgs e)
        {
            mysqlItems mysqlItemsForm = new mysqlItems(this);

            if (mysqlItemsForm.ShowDialog(this) == DialogResult.OK)
            {
                string itemKeyname = mysqlItemsForm.selectedItemKeyname;
                if (itemKeyname != "")
                {
                    item.loadFromDatabase(this.mysqlConnection, itemKeyname, this.mysqlRow.ItemTemplateTable);
                    loadItemValues();
                }
            }
            mysqlItemsForm.Dispose();
        }

        #endregion

        #region itemKeyword checking

        public bool checkKeywordMysql()
        {
            if (mysql_enabled == true && this.item_keyname.Text.Trim() != "")
            {
                try
                {
                    this.mysqlConnection.Open();

                    MySqlDataReader reader = null;
                    MySqlCommand cmd = new MySqlCommand("SELECT Name, ItemTemplate_ID FROM " + mysqlRow.ItemTemplateTable + " WHERE Id_nb = '" + this.item_keyname.Text + "' LIMIT 0,1", this.mysqlConnection);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string itemName = reader.GetString(0);

                        //Das Item Existiert, die Guid aus der Datenbank holen um doppelte zu vermeiden
                        this.item.ItemTemplate.Rows[0]["ItemTemplate_ID"] = reader.GetString("ItemTemplate_ID");

                        //MessageBox.Show("This Keyname is used by \"" + itemName + "\"");
                        this.item_keyname.BackColor = Color.LightSalmon;
                        this.errorProvider.SetIconPadding(this.item_keyname, -16);

                        //Message: This Keyname is used by "ITEMNAME"
                        string message = String.Format(Locales.GetString("error_itemkey_in_use_by"), itemName);
                        this.errorProvider.SetError(this.item_keyname, message);
                    }
                    else
                    {                    
                        //Das Item ist neu, also wird eine neue Guid erstellt
                        this.item.ItemTemplate.Rows[0]["ItemTemplate_ID"] = System.Guid.NewGuid().ToString();
                        
                        this.item_keyname.BackColor = Color.LightGreen;
                        this.errorProvider.Clear();

                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mysqlConnection.Close();
                }
            }

            return false;
        }

        private void checkKeyword_Click(object sender, EventArgs e)
        {
            checkKeywordMysql();
        }

        private void item_keyname_Enter(object sender, EventArgs e)
        {
            this.item_keyname.BackColor = Color.White;
            this.errorProvider.Clear();
        }

        #endregion

        #region selection Forms

        private void setMysqlConnection()
        {
            if (mysqlRow != null && mysqlRow.Enabled == true)
            {
                DialogResult mysqlDialog;
                
                mysql_test mysqlTest = new mysql_test(mysqlRow);
                mysqlDialog = mysqlTest.DialogResult;
                if (mysqlDialog == DialogResult.OK)
                {
                    this.mysqlConnection = mysqlTest.mysqlConnection;
                    this.mysql_enabled = true;
                }
                else
                {
                    mysqlTest.ShowDialog();

                    mysqlDialog = mysqlTest.DialogResult;
                    if (mysqlDialog == DialogResult.OK)
                    {
                        this.mysqlConnection = mysqlTest.mysqlConnection;
                        this.mysql_enabled = true;
                    }
                    else this.mysql_enabled = false;
                }
                mysqlTest.Dispose();
            }
            else this.mysql_enabled = false;

            //Buttons zur mysql unterstützung de-/aktivieren
            if (mysql_enabled == false)
            {
                this.checkKeyword.Enabled = false;
                this.searchSpellID.Enabled = false;
                this.searchSpellID1.Enabled = false;
                this.searchProcSpellID.Enabled = false;
                this.searchProcSpellID1.Enabled = false;
                this.searchPoisonSpellID.Enabled = false;
                this.loadItemFromDatabase.Enabled = false;
            }
            else
            {
                this.checkKeyword.Enabled = true;
                this.searchSpellID.Enabled = true;
                this.searchSpellID1.Enabled = true;
                this.searchProcSpellID.Enabled = true;
                this.searchProcSpellID1.Enabled = true;
                this.searchPoisonSpellID.Enabled = true;
                this.loadItemFromDatabase.Enabled = true;
            }

            if(item.ItemTemplate.Count > 0) getLootTemplatesOfItem();
        }

        private void selectSpell(object sender, EventArgs e)
        {
            spellIDs spellForm = new spellIDs(this);
            DialogResult result = spellForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Name der zu editierenden spalte aus dem Buttonnamen holen, "search" entfernen
                Control senderControl = (Control)sender;
                string columnName = senderControl.Name.Substring(6);
                this.item.ItemTemplate.Rows[0][columnName] = spellForm.selectedSpellID;
                Control textControl = (Control)this.Controls.Find("item_" + columnName, true)[0];
                textControl.Text = spellForm.selectedSpellID;
            }
        }

        private void selectModelId(object sender, EventArgs e)
        {
            modelIds modelIdsForm = new modelIds();

            if (modelIdsForm.ShowDialog(this) == DialogResult.OK)
            {
                this.item.ItemTemplate.Rows[0]["model"] = modelIdsForm.selectedModelId;
                this.item_model_id.Text = modelIdsForm.selectedModelId.ToString();
            }
            modelIdsForm.Dispose();
        }

        #endregion

        #region ItemCheck and Export

        private bool checkItem()
        {
            //Prüfen ob das Item alle nötigen eigenschaften hat

            //Ist ein Name eingegeben?
            if (this.item_name.Text.Trim() == "")
            {
                //Message: You need to set an Itemname!
                MessageBox.Show(Locales.GetString("error_no_itemname"));
                return false;
            }

            //Ist ein Keywort eingegeben?
            if (this.item_keyname.Text.Trim() == "")
            {
                //Mesasage: You need to set a Keyname!
                MessageBox.Show(Locales.GetString("error_no_itemkeyname"));
                return false;
            }
            else if (mysql_enabled == true) checkKeywordMysql();

            //Ist ein Model eingegeben
            if (Convert.ToInt32(this.item_model_id.Text) == 0)
            {
                //Message: You need to set a Model ID!
                MessageBox.Show(Locales.GetString("error_no_model_id"));
                return false;
            }

            return true;
        }

        private void checkItemButton_click(object sender, EventArgs e)
        {
            checkItem();
        }

        private void exportItem_click(object sender, EventArgs e)
        {
            if (checkItem() == true)
            {
                setItem();

                exportItem exportItemForm = new exportItem(this);
                exportItemForm.ShowDialog();
            }
        }

        #endregion

        #region Updater

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Application.StartupPath + "//Items"))
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "//Items");
            }

            if (itemSaved == false && this.basicRow.askSaveToFile == true)
            {
                //Message: Save Item
                DialogResult dialog = MessageBox.Show(Locales.GetString("save_item_ask"), Locales.GetString("save_item_title"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                //User klickt ja
                if (dialog == DialogResult.Yes)
                {
                    saveItem(null, null);
                }
                else if (dialog == DialogResult.Cancel)
                {
                    return;
                }
            }
            
            updaterForm updaterFormular = new updaterForm(this);
            DialogResult result = updaterFormular.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                if (updaterFormular.startUpdater == true)
                {
                    try
                    {
                        // Shut down the current app instance
                        Application.ExitThread();
                        System.Diagnostics.Process.Start(Application.StartupPath + "//ItemCreatorUpdater.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (updaterFormular.restartApp == true)
                {
                    try
                    {
                        // Shut down the current app instance
                        Application.Restart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        #endregion

        #region Loot & Dropchances

        private void updateLootTemplateList_Click(object sender, EventArgs e)
        {
            getLootTemplatesOfItem();
        }

        private void lootTemplateDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            getMobsOfLootTemplate();
        }

        private void updateMobXTemplateList_Click(object sender, EventArgs e)
        {
            getMobsOfLootTemplate();
        }

        private bool itemExists = false;
        private void getLootTemplatesOfItem()
        {
            //Prüfen ob das Item bereits in der Datenbank gespeichert wurde
            // + MysqlEnabled

            if (this.mysql_enabled == true && item.ItemTemplate[0].Id_nb != "")
            {
                if (this.mysqlConnection.State != ConnectionState.Open) this.mysqlConnection.Open();
                try
                {
                    MySqlDataReader reader = null;
                    MySqlCommand cmd = new MySqlCommand("SELECT Name, ItemTemplate_ID FROM " + mysqlRow.ItemTemplateTable + " WHERE Id_nb = '" + this.item_keyname.Text + "' LIMIT 0,1", this.mysqlConnection);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string itemName = reader.GetString(0);

                        //Prüfen ob es sich um das gleiche Item handelt
                        if (itemName == item.ItemTemplate[0].Name)
                        {
                            itemExists = true;
                        }
                        else
                        {
                            //Message: This Item does not exist in the Database!
                            lootTemplateInfo.Text = Locales.GetString("error_item_not_in_database");
                            itemExists = false;
                        }
                    }
                    else
                    {
                        //Message: This Item does not exist in the Database!
                        lootTemplateInfo.Text = Locales.GetString("error_item_not_in_database");
                        itemExists = false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.mysqlConnection.Close();
                }

                //Hole alle ItemTemplates
                if (itemExists == true)
                {
                    this.mysqlConnection.Open();
                    try
                    {
                        string SQL = "SELECT LootTemplate_ID, TemplateName, ItemTemplateID, Chance FROM " + mysqlRow.LootTemplateTable + " WHERE ItemTemplateID = '" + item.ItemTemplate[0].Id_nb + "'";
                        DataSet result = MySqlHelper.ExecuteDataset(this.mysqlConnection, SQL);
                        this.lootTemplatesList.LootTemplate.Clear();
                        this.mobXLootTemplateList.MobXLootTemplate.Clear();
                        this.lootTemplatesList.LootTemplate.Merge(result.Tables[0]);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //Message: No LootTemplates found!
                        if (this.lootTemplatesList.LootTemplate.Count == 0) lootTemplateInfo.Text = Locales.GetString("message_no_loottemplates");
                        else lootTemplateInfo.Text = "";

                        if (this.mysqlConnection.State == ConnectionState.Open) this.mysqlConnection.Close();
                    }
                }
                else
                {
                    this.lootTemplatesList.LootTemplate.Clear();
                    this.mobXLootTemplateList.MobXLootTemplate.Clear();
                }
            }
            else
            {
                //Message: MySQL-support is not enabled!
                if (this.mysql_enabled != true) lootTemplateInfo.Text = Locales.GetString("message_no_mysql_support");
                //Message: No Itemkeyname is set!
                else if (item.ItemTemplate[0].Id_nb == "") lootTemplateInfo.Text = Locales.GetString("message_no_itemkeyname");
                itemExists = false;
                this.lootTemplatesList.LootTemplate.Clear();
                this.mobXLootTemplateList.MobXLootTemplate.Clear();
            }
        }

        private void lootTemplateContextMenu_Opening(object sender, CancelEventArgs e)
        {
            //getLootTemplatesOfItem();
            
            if (itemExists) newLootTemplateButton.Enabled = true;
            else newLootTemplateButton.Enabled = false;
            
            if (lootTemplateDataGrid.SelectedRows.Count == 1)
            {
                deleteTemplateButton.Enabled = true;
                editLottTemplateEntry.Enabled = true;
            }
            else
            {
                deleteTemplateButton.Enabled = false;
                editLottTemplateEntry.Enabled = false;
            }
        }

        private void getMobsOfLootTemplate()
        {
            if (lootTemplateDataGrid.SelectedRows.Count == 1)
            {
                string lootTemplateName = (string)this.lootTemplateDataGrid.SelectedRows[0].Cells["templateNameDataGridViewTextBoxColumn"].Value;

                if(this.mysqlConnection.State != ConnectionState.Open) this.mysqlConnection.Open();
                try
                {
                    string SQL = "SELECT MobXLootTemplate_ID, MobName, LootTemplateName, DropCount FROM " + mysqlRow.MobXLootTemplateTable + " WHERE LootTemplateName = '" + lootTemplateName + "'";
                    DataSet result = MySqlHelper.ExecuteDataset(this.mysqlConnection, SQL);
                    this.mobXLootTemplateList.MobXLootTemplate.Clear();
                    this.mobXLootTemplateList.MobXLootTemplate.Merge(result.Tables[0]);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //Message: No assigned mobs found!
                    if (this.mobXLootTemplateList.MobXLootTemplate.Count == 0) mobTemplateInfo.Text = Locales.GetString("message_no_assigned_mobs");
                    else mobTemplateInfo.Text = "";

                    if (this.mysqlConnection.State == ConnectionState.Open) this.mysqlConnection.Close();
                }
            }
            //Message: LootTemplates needed!
            else mobTemplateInfo.Text = Locales.GetString("message_loot_templates_needed");
        }

        private void mobxTemplateContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (lootTemplateDataGrid.SelectedRows.Count >= 1) newMobTemplate.Enabled = true;
            else newMobTemplate.Enabled = false;

            if (mobXTemplateDataGrid.SelectedRows.Count == 1)
            {
                deleteMobTemplate.Enabled = true;
                editMobTemplate.Enabled = true;
            }
            else
            {
                deleteMobTemplate.Enabled = false;
                editMobTemplate.Enabled = false;
            }
        }

        private void newLootTemplateButton_Click(object sender, EventArgs e)
        {
            newLootTemplate newLootTemplateForm = new newLootTemplate(this);
            DialogResult result = newLootTemplateForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                getLootTemplatesOfItem();
            }
        }

        private void editLottTemplateEntry_Click(object sender, EventArgs e)
        {
            string LootTemplate_ID = (string)this.lootTemplateDataGrid.SelectedRows[0].Cells["lootTemplateIDDataGridViewTextBoxColumn"].Value;

            editLootTemplate editLootTemplateForm = new editLootTemplate(this, LootTemplate_ID);
            DialogResult result = editLootTemplateForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                getLootTemplatesOfItem();
            }
        }

        private void deleteTemplateButton_Click(object sender, EventArgs e)
        {
            string lootTemplateId = (string)this.lootTemplateDataGrid.SelectedRows[0].Cells["lootTemplateIDDataGridViewTextBoxColumn"].Value;
            string lootTemplateName = (string)this.lootTemplateDataGrid.SelectedRows[0].Cells["templateNameDataGridViewTextBoxColumn"].Value;

            //Message: Do you really want to delete this entry?
            //Title: Delete LootTemplate
            DialogResult result = MessageBox.Show(Locales.GetString("ask_delete_entry"), Locales.GetString("ask_delete_loot_template_title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (this.mysqlConnection.State != ConnectionState.Open) this.mysqlConnection.Open();

                    string SQL = "DELETE FROM " + mysqlRow.LootTemplateTable + " WHERE LootTemplate_ID = '" + lootTemplateId + "' LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(SQL, this.mysqlConnection);
                    int affectedRows = cmd.ExecuteNonQuery();

                    getLootTemplatesOfItem();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + System.Environment.NewLine + "@ deleting LootTemplate");
                }
                finally
                {
                    this.mysqlConnection.Close();
                }

                //Message: Delete all assigned MobXLootTemplates of this LootTemplate?
                //Title: Delete assigned MobXLootTemplates
                DialogResult mobxresult = MessageBox.Show(Locales.GetString("ask_delete_assigned_mobxloottemplates"), Locales.GetString("ask_delete_assigned_mobxloottemplates_title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mobxresult == DialogResult.Yes)
                {
                    try
                    {
                        if (this.mysqlConnection.State != ConnectionState.Open) this.mysqlConnection.Open();

                        string SQL = "DELETE FROM " + mysqlRow.MobXLootTemplateTable + " WHERE LootTemplateName = '" + lootTemplateName + "'";

                        MySqlCommand cmd = new MySqlCommand(SQL, this.mysqlConnection);
                        int affectedRows = cmd.ExecuteNonQuery();

                        //Message: NUMBER MobXLootTemplates deleted!
                        string message = String.Format(Locales.GetString("num_deleted_mobxloottemplates"), affectedRows.ToString());
                        MessageBox.Show(message);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + System.Environment.NewLine + "@ deleting MobXLootTemplate");
                    }
                    finally
                    {
                        this.mysqlConnection.Close();
                    }
                }
            }
        }

        private void newMobTemplate_Click(object sender, EventArgs e)
        {
            string LootTemplateName = (string)this.lootTemplateDataGrid.SelectedRows[0].Cells["templateNameDataGridViewTextBoxColumn"].Value;

            newMobAssignment newMobAssignmentForm = new newMobAssignment(this, LootTemplateName);
            DialogResult result = newMobAssignmentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                getMobsOfLootTemplate();
            }
        }

        private void editMobTemplate_Click(object sender, EventArgs e)
        {
            string mobXLootTemplateID = (string)this.mobXTemplateDataGrid.SelectedRows[0].Cells["mobXLootTemplateIDDataGridViewTextBoxColumn"].Value;

            editMobAssignment editMobAssignmentForm = new editMobAssignment(this, mobXLootTemplateID);
            DialogResult result = editMobAssignmentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                getMobsOfLootTemplate();
            }
        }

        private void deleteMobTemplate_Click(object sender, EventArgs e)
        {
            //Message: Do you really want to delete this entry?
            //Title: Delete MobXLootTemplate
            DialogResult result = MessageBox.Show(Locales.GetString("ask_delete_entry"), Locales.GetString("ask_delete_mobxloottemplate_title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string mobXLootTemplateID = (string)this.mobXTemplateDataGrid.SelectedRows[0].Cells["mobXLootTemplateIDDataGridViewTextBoxColumn"].Value;
                try
                {
                    if (this.mysqlConnection.State != ConnectionState.Open) this.mysqlConnection.Open();

                    string SQL = "DELETE FROM " + mysqlRow.MobXLootTemplateTable + " WHERE MobXLootTemplate_ID = '" + mobXLootTemplateID + "' LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(SQL, this.mysqlConnection);
                    int affectedRows = cmd.ExecuteNonQuery();

                    getMobsOfLootTemplate();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + System.Environment.NewLine + "@ deleting MobXLootTemplate");
                }
                finally
                {
                    this.mysqlConnection.Close();
                }
            }
        }

        #endregion

        #region languages

        private DataTable languages = null;
        private DataTable getLanguageCodes()
        {
            DataTable dt = new DataTable();
            //Basic Table
            dt.Columns.Add("language");
            dt.Columns.Add("language_code");

            //Delimiter for whole language
            char[] lang_delimiter = { ',' };
            //Delimter splits language and language_code
            char[] language_code_delimiter = { '=' };

            string supported_languages = Properties.Settings.Default.supported_languages;
            string[] supported_languages_array = supported_languages.Split(lang_delimiter);
            foreach (string current in supported_languages_array)
            {
                dt.Rows.Add(current.Split(language_code_delimiter));
            }

            return dt;
        }


        private void setLanguagesMenu()
        {
            languages = this.getLanguageCodes();
            ToolStripMenuItem languageMenu = this.languageToolStripMenuItem;

            ToolStripItem[] languageItems = new ToolStripItem[languages.Rows.Count];
            int count = 0;
            foreach (DataRow language in languages.Rows)
            {
                ToolStripMenuItem languageItem = new ToolStripMenuItem();
                languageItem.Text = language["language"].ToString();
                languageItem.Name = "select_language_" + language["language_code"].ToString();
                languageItem.Click += new EventHandler(languageItem_Click);

                if (language["language_code"].ToString() == Properties.Settings.Default.language)
                {
                    languageItem.Checked = true;
                }

                languageItems.SetValue(languageItem, count);
                count++;
            }
            languageMenu.DropDownItems.AddRange(languageItems);
        }

        void languageItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem control = (ToolStripMenuItem)sender;
            string language = control.Name;
            language = language.Substring(16);
            if (language != Properties.Settings.Default.language)
            {   
                Properties.Settings.Default.language = language;
                Properties.Settings.Default.Save();
                MessageBox.Show("The Applicatione needs to be restarted.", "Language changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            }
        }

        #endregion

        #region other frames

        private void aboutForm_click(object sender, EventArgs e)
        {
            about aboutForm = new about();
            aboutForm.ShowDialog();
        }

        private void dawnOfLightHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string link = @"http://www.dolserver.net";
            System.Diagnostics.Process.Start(link);
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string link = @"http://www.dolserver.net/viewtopic.php?f=21&t=6837";
            System.Diagnostics.Process.Start(link);
        }

        #endregion
    }
}