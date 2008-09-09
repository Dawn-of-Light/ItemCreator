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
    public partial class spellIDs : Form
    {
        private MainForm mainForm;

        private string _selectedSpellID = "";
        public string selectedSpellID
        {
            get { return _selectedSpellID; }
            set { _selectedSpellID = value; }
        }
        
        public spellIDs(MainForm sender)
        {
            this.mainForm = sender;
            
            InitializeComponent();

            loadSearchOptions();
            getTableData(0);
        }

        private void loadSearchOptions()
        {
            try
            {
                mainForm.mysqlConnection.Open();

                //Targets
                MySqlDataReader reader;
                MySqlCommand cmd;

                cmd = new MySqlCommand("SELECT DISTINCT Target FROM " + this.mainForm.mysqlRow.SpellTable + "  WHERE Target != NULL  ", mainForm.mysqlConnection);
                reader = cmd.ExecuteReader();

                this.targetComboBox.Items.Add("");
                while (reader.Read())
                {
                    this.targetComboBox.Items.Add(reader.GetString("Target"));
                }
                reader.Close();

                //mainForm.mysqlConnection.Close();
                //mainForm.mysqlConnection.Open();

                cmd = new MySqlCommand("SELECT DISTINCT Type FROM " + this.mainForm.mysqlRow.SpellTable + " WHERE Type != NULL ", mainForm.mysqlConnection);
                reader = cmd.ExecuteReader();

                this.typesComboBox.Items.Add("");
                while (reader.Read())
                {
                    this.typesComboBox.Items.Add(reader.GetString("Type"));
                }

                this.data_per_page.SelectedItem = "50";
                this.order_by.SelectedItem = "SpellID";

                this.data_per_page.SelectedIndexChanged += new EventHandler(this.reloadData);
                this.order_by.SelectedIndexChanged += new EventHandler(this.reloadData);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mainForm.mysqlConnection.Close();
            }
        }

        private void getTableData(int page)
        {

            try
            {
                int fromValue = page * Convert.ToInt32(this.data_per_page.SelectedItem);

                string SQL = "SELECT SpellID, Name, Target, Type, Value, Description FROM " + this.mainForm.mysqlRow.SpellTable + " WHERE 1 ";
                string countSQL = "SELECT count(*) FROM " + this.mainForm.mysqlRow.SpellTable + " WHERE 1 ";
                string addingSQL = "";

                if (this.spellName.Text != "") addingSQL += " AND Name LIKE '%" + this.spellName.Text + "%' ";
                if (this.targetComboBox.Text != "") addingSQL += " AND Target = '" + this.targetComboBox.Text + "' ";
                if (this.typesComboBox.Text != "") addingSQL += " AND Type = '" + this.typesComboBox.Text + "' ";

                if (addingSQL != "")
                {
                    SQL += addingSQL;
                    countSQL += addingSQL;
                }
                SQL += " ORDER BY " + this.order_by.SelectedItem + " LIMIT " + fromValue + ", " + this.data_per_page.SelectedItem;

                mainForm.mysqlConnection.Open();

                MySqlDataReader reader;
                MySqlCommand cmd;

                //Count
                cmd = new MySqlCommand(countSQL, mainForm.mysqlConnection);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    decimal anzahlSeiten = reader.GetInt32(0) / Convert.ToInt32(this.data_per_page.SelectedItem);
                    this.current_page.Maximum = Math.Floor(anzahlSeiten);
                    this.pages_total.Text = Convert.ToString(Math.Floor(anzahlSeiten));
                }
                reader.Close();

                //Data
                cmd = new MySqlCommand(SQL, mainForm.mysqlConnection);
                reader = cmd.ExecuteReader();

                this.spellList.Spell.Clear();
                while (reader.Read())
                {
                    Spells.SpellRow row = spellList.Spell.NewSpellRow();
                    row.SpellID = reader.GetInt32("SpellID");
                    row.Name = reader.GetString("Name");
                    row.Target = reader.GetString("Target");

                    if (reader.IsDBNull(3) == true) row.Type = "";
                    else row.Type = reader.GetString("Type");

                    if (reader.IsDBNull(4) == true) row.Value = 0;
                    else row.Value = reader.GetInt32("Value");

                    row.Description = reader.GetString("Description");

                    this.spellList.Spell.Rows.Add(row);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mainForm.mysqlConnection.Close();
            }

        }

        private void searchSpells(object sender, EventArgs e)
        {
            if (this.current_page.Value != 0)
            {
                this.current_page.Value = 0;
                this.current_page.Maximum = 0;
            }
            else getTableData(0);
        }

        private void current_page_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
            getTableData(Convert.ToInt32(control.Value));
        }

        private void selectSpellId()
        {
            if (spellDataGrid.SelectedRows.Count > 0)
            {
                selectedSpellID = Convert.ToString(spellDataGrid.SelectedRows[0].Cells[0].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else selectedSpellID = "0";
        }

        private void selectSpellButton_Click(object sender, EventArgs e)
        {
            selectSpellId();
        }

        private void spellDataGrid_Enter(object sender, EventArgs e)
        {
            selectSpellButton.Enabled = true;
        }

        private void reloadData(object sender, EventArgs e)
        {
            getTableData((int)this.current_page.Value);
        }
    }
}