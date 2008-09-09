using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ItemCreator.database;

namespace ItemCreator
{
    public partial class preferencesForm : Form
    {
        private string filename;
        private MainForm mainForm;

        public preferencesForm(MainForm mainForm, string filename)
        {
            this.mainForm = mainForm;
            this.filename = filename;

            InitializeComponent();
            loadPreferences();
        }

        private void loadPreferences()
        {
            if (System.IO.File.Exists(filename))
            {
                foreach (DataTable dataTable in preferences.Tables) dataTable.BeginLoadData();
                preferences.ReadXml(filename);
                foreach (DataTable dataTable in preferences.Tables) dataTable.EndLoadData();
            }
            else
            {
                Preferences.MySQLRow mysqlRow = this.preferences.MySQL.NewMySQLRow();
                preferences.MySQL.Rows.Add(mysqlRow);

                Preferences.BasicRow basicRow = this.preferences.Basic.NewBasicRow();
                preferences.Basic.Rows.Add(basicRow);
                
                this.preferences.WriteXml(filename);
                loadPreferences();
            }

            //Set default values for new options in MySQLRow
            Preferences.MySQLRow checkingMySQLRow = (Preferences.MySQLRow)this.preferences.MySQL.Rows[0];
            //cellDetection
            if (checkingMySQLRow.IscellDetectionNull())
            {
                if (checkingMySQLRow.Enabled == true) checkingMySQLRow.cellDetection = true;
                else checkingMySQLRow.cellDetection = false;
            }
            //ArtiID
            if (checkingMySQLRow.IsArtiIDNull()) checkingMySQLRow.ArtiID = true;
            //LootTemplateTable
            if (checkingMySQLRow.IsLootTemplateTableNull()) checkingMySQLRow.LootTemplateTable = "LootTemplate";
            //MobXLootTemplate
            if (checkingMySQLRow.IsMobXLootTemplateTableNull()) checkingMySQLRow.MobXLootTemplateTable = "MobXLootTemplate";

            //Set default values for new options in BasicRow
            Preferences.BasicRow checkingBasicRow = (Preferences.BasicRow)this.preferences.Basic.Rows[0];
            //check Application updates
            if (checkingBasicRow.IscheckApplicationUpdatesNull()) checkingBasicRow.checkApplicationUpdates = true;
            //check Database updates
            if (checkingBasicRow.IscheckDatabaseUpdatesNull()) checkingBasicRow.checkDatabaseUpdates = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            Preferences.MySQLRow mysqlRow = (Preferences.MySQLRow)preferences.MySQL.Rows[0];

            MySqlConnectionStringBuilder conString = new MySqlConnectionStringBuilder();
            conString.Server = mysqlRow.Host;
            conString.Port = mysqlRow.Port;
            conString.Database = mysqlRow.Database;
            conString.UserID = mysqlRow.UserID;
            conString.Password = mysqlRow.Password;

            MySqlConnection con = new MySqlConnection(conString.ConnectionString);
            try
            {
                con.Open();
                //Message: Successfull connected!
                MessageBox.Show(mainForm.Locales.GetString("message_connection_successfull"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void automaticDetection_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            standardCellsGroupBox.Enabled = !check.Checked;
        }

        private void enableMysql_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            automaticGroupBox.Enabled = check.Checked;
            automaticDetection.Checked = check.Checked;
        }
    }
}