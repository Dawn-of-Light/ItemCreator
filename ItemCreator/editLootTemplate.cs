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
    public partial class editLootTemplate : Form
    {
        private MainForm opener;

        public editLootTemplate(MainForm opener, string LootTemplate_ID)
        {
            this.opener = opener;

            InitializeComponent();
            this.selectRealm.DataSource = this.opener.baseXMLData;
            this.selectRealm.DisplayMember = "realm.name";
            this.selectRealm.ValueMember = "realm.id";


            try
            {
                if (opener.mysqlConnection.State != ConnectionState.Open) opener.mysqlConnection.Open();

                string SQL = "SELECT LootTemplate_ID, TemplateName, ItemTemplateID, Chance FROM " + opener.mysqlRow.LootTemplateTable + " WHERE LootTemplate_ID = '" + LootTemplate_ID + "' LIMIT 0,1";

                MySqlCommand cmd = new MySqlCommand(SQL, opener.mysqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                lootTemplateIDTextbox.Text = reader.GetString("LootTemplate_ID");
                templateNameTextBox.Text = reader.GetString("TemplateName");
                itemTemplateIdTextBox.Text = reader.GetString("ItemTemplateID");
                chanceTextBox.Text = reader.GetInt32("Chance").ToString();
                //this.selectRealm.SelectedValue = reader.GetInt32("Realm");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + System.Environment.NewLine + "@ getting data of LootTemplate");
            }
            finally
            {
                opener.mysqlConnection.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Prüfen ob alle Werte getzt sind
            if (lootTemplateIDTextbox.Text == "")
            {
                MessageBox.Show("ERROR: LootTemplate_ID is not set!");
                return;
            }

            if (templateNameTextBox.Text == "")
            {
                MessageBox.Show("You need to set a TemplateName");
                return;
            }
            if (itemTemplateIdTextBox.Text == "")
            {
                MessageBox.Show("ERROR: No ItemTemplateID is set!");
                return;
            }
            if (chanceTextBox.Text == "")
            {
                MessageBox.Show("Define a dropchance!");
                return;
            }

            try
            {
                if (opener.mysqlConnection.State != ConnectionState.Open) opener.mysqlConnection.Open();

                string SQL = "REPLACE INTO " + opener.mysqlRow.LootTemplateTable + " (LootTemplate_ID, TemplateName, ItemTemplateID, Chance) VALUES (";
                SQL += "'" + lootTemplateIDTextbox.Text + "', ";
                SQL += "'" + templateNameTextBox.Text + "', ";
                SQL += "'" + itemTemplateIdTextBox.Text + "', ";
                SQL += chanceTextBox.Text + ") ";
                //SQL += selectRealm.SelectedValue + ") ";

                MySqlCommand cmd = new MySqlCommand(SQL, opener.mysqlConnection);
                int affectedRows = cmd.ExecuteNonQuery();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + System.Environment.NewLine + "@ updating data of LootTemplate");
            }
            finally
            {
                opener.mysqlConnection.Close();
            }
        }
    }
}