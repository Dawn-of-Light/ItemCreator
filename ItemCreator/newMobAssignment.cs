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
    public partial class newMobAssignment : Form
    {
        private MainForm opener;
        
        public newMobAssignment(MainForm opener, string LootTemplateName)
        {
            this.opener = opener;

            InitializeComponent();

            this.lootTemplateIdTextBox.Text = LootTemplateName;
            this.dropCountTextBox.Text = "1";
            this.createGuid.Checked = true;
        }

        private void createGuid_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk.Checked == true)
            {
                string guid = System.Guid.NewGuid().ToString();
                mobxtemplateIdTextBox.Text = guid;
                mobxtemplateIdTextBox.Enabled = false;
            }
            else
            {
                mobxtemplateIdTextBox.Text = "";
                mobxtemplateIdTextBox.Enabled = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Prüfen ob alle Werte getzt sind
            if (mobxtemplateIdTextBox.Text.Trim() == "")
            {
                MessageBox.Show("You need to set a unique MobXLootTemplate_ID!");
                return;
            }
            else
            {
                try
                {
                    if (opener.mysqlConnection.State != ConnectionState.Open) opener.mysqlConnection.Open();

                    string SQL = "SELECT * FROM " + opener.mysqlRow.MobXLootTemplateTable + " WHERE MobXLootTemplate_ID = '" + mobxtemplateIdTextBox.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(SQL, opener.mysqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("The MobXLootTemplate_ID is not unique!");
                        return;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + System.Environment.NewLine + "@ checking MobXLootTemplate_ID");
                }
                finally
                {
                    opener.mysqlConnection.Close();
                }
            }

            if (mobNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("You need to set a MobName!");
                return;
            }
            if (lootTemplateIdTextBox.Text.Trim() == "")
            {
                MessageBox.Show("ERROR: No LootTemplateID is set!");
                return;
            }
            if (dropCountTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Define a drop count!");
                return;
            }

            try
            {
                if (opener.mysqlConnection.State != ConnectionState.Open) opener.mysqlConnection.Open();

                string SQL = "INSERT INTO " + opener.mysqlRow.MobXLootTemplateTable + " (MobXLootTemplate_ID, MobName, LootTemplateName, DropCount) VALUES (";
                SQL += "'" + mobxtemplateIdTextBox.Text.Trim() + "', ";
                SQL += "'" + mobNameTextBox.Text.Trim() + "', ";
                SQL += "'" + lootTemplateIdTextBox.Text.Trim() + "', ";
                SQL += dropCountTextBox.Text.Trim() + ") ";

                MySqlCommand cmd = new MySqlCommand(SQL, opener.mysqlConnection);
                int affectedRows = cmd.ExecuteNonQuery();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + System.Environment.NewLine + "@ adding MobXLootTemplate");
            }
            finally
            {
                opener.mysqlConnection.Close();
            }
        }
    }
}