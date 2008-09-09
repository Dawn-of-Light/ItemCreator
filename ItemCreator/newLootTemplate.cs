using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ItemCreator
{
    public partial class newLootTemplate : Form
    {
        private MainForm opener;
        
        public newLootTemplate(MainForm opener)
        {
            this.opener = opener;

            InitializeComponent();
            this.itemTemplateIdTextBox.Text = opener.item.ItemTemplate[0].Id_nb;
            this.selectRealm.DataSource = this.opener.baseXMLData;
            this.selectRealm.DisplayMember = "realm.name";
            this.selectRealm.ValueMember = "realm.id";
            this.createGuid.Checked = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Prüfen ob alle Werte getzt sind
            if (lootTemplateIDTextbox.Text.Trim() == "")
            {
                MessageBox.Show("You need to set a unique LootTemplate_ID!");
                return;
            }
            else
            {
                try
                {
                    if (opener.mysqlConnection.State != ConnectionState.Open) opener.mysqlConnection.Open();

                    string SQL = "SELECT * FROM " + opener.mysqlRow.LootTemplateTable + " WHERE LootTemplate_ID = '" + lootTemplateIDTextbox.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(SQL, opener.mysqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("The LootTemplate_ID is not unique!");
                        return;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + System.Environment.NewLine + "@ checking LootTemplate_ID");
                }
                finally
                {
                    opener.mysqlConnection.Close();
                }
            }

            if (templateNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("You need to set a TemplateName!");
                return;
            }
            if (itemTemplateIdTextBox.Text.Trim() == "")
            {
                MessageBox.Show("No ItemTemplateID is set!");
                return;
            }
            if (chanceTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Define a dropchance!");
                return;
            }

            try
            {
                if (opener.mysqlConnection.State != ConnectionState.Open) opener.mysqlConnection.Open();
                
                string SQL = "INSERT INTO " + opener.mysqlRow.LootTemplateTable + " (LootTemplate_ID, TemplateName, ItemTemplateID, Chance) VALUES (";
                SQL += "'" + lootTemplateIDTextbox.Text.Trim() + "', ";
                SQL += "'" + templateNameTextBox.Text.Trim() + "', ";
                SQL += "'" + itemTemplateIdTextBox.Text.Trim() + "', ";
                SQL += chanceTextBox.Text.Trim() + ") ";
                //SQL += selectRealm.SelectedValue + ") ";

                MySqlCommand cmd = new MySqlCommand(SQL, opener.mysqlConnection);
                int affectedRows = cmd.ExecuteNonQuery();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + System.Environment.NewLine + "@ adding LootTemplate");
            }
            finally
            {
                opener.mysqlConnection.Close();
            }
        }

        private void createGuid_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk.Checked == true)
            {
                string guid = System.Guid.NewGuid().ToString();
                lootTemplateIDTextbox.Text = guid;
                lootTemplateIDTextbox.Enabled = false;
            }
            else
            {
                lootTemplateIDTextbox.Text = "";
                lootTemplateIDTextbox.Enabled = true;
            }
        }
    }
}