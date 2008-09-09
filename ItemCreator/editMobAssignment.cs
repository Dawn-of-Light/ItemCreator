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
    public partial class editMobAssignment : Form
    {
        private MainForm opener;

        public editMobAssignment(MainForm opener, string MobXLootTemplate_ID)
        {
            this.opener = opener;

            InitializeComponent();

            try
            {
                if (opener.mysqlConnection.State != ConnectionState.Open) opener.mysqlConnection.Open();

                string SQL = "SELECT MobXLootTemplate_ID, MobName, LootTemplateName, DropCount FROM " + opener.mysqlRow.MobXLootTemplateTable + " WHERE MobXLootTemplate_ID = '" + MobXLootTemplate_ID + "' LIMIT 0,1";

                MySqlCommand cmd = new MySqlCommand(SQL, opener.mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                mobxtemplateIdTextBox.Text = reader.GetString("MobXLootTemplate_ID");
                mobNameTextBox.Text = reader.GetString("MobName");
                lootTemplateIdTextBox.Text = reader.GetString("LootTemplateName");
                dropCountTextBox.Text = reader.GetInt32("DropCount").ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + System.Environment.NewLine + "@ getting data of MobXLootTemplate");
            }
            finally
            {
                opener.mysqlConnection.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Prüfen ob alle Werte getzt sind
            if (mobxtemplateIdTextBox.Text.Trim() == "")
            {
                MessageBox.Show("ERROR: MobXLootTemplate_ID is not set!");
                return;
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

                string SQL = "REPLACE INTO " + opener.mysqlRow.MobXLootTemplateTable + " (MobXLootTemplate_ID, MobName, LootTemplateName, DropCount) VALUES (";
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
                MessageBox.Show(ex.Message + System.Environment.NewLine + "@ updating MobXLootTemplate");
            }
            finally
            {
                opener.mysqlConnection.Close();
            }
        }
    }
}