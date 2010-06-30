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
    public partial class mysqlItems : Form
    {
        private MainForm mainForm;

        private string _selectedItemKeyname = "";
        public string selectedItemKeyname
        {
            get { return _selectedItemKeyname; }
            set { _selectedItemKeyname = value; }
        }

        public mysqlItems(MainForm sender)
        {
            this.mainForm = sender;
            
            InitializeComponent();

            this.order_by.SelectedItem = "Id_nb";
            this.data_per_page.SelectedItem = "50";

            this.data_per_page.SelectedIndexChanged += new EventHandler(this.reloadData);
            this.order_by.SelectedIndexChanged += new EventHandler(this.reloadData);

            getTableData(0);
        }

        private void getTableData(int page)
        {
            try
            {
                int fromValue = page * Convert.ToInt32(this.data_per_page.SelectedItem);

                string SQL = "SELECT Id_nb, Name, Level FROM " + this.mainForm.mysqlRow.ItemTemplateTable + " WHERE 1 ";
                string countSQL = "SELECT count(*) FROM " + this.mainForm.mysqlRow.ItemTemplateTable + " WHERE 1 ";
                string addingSQL = "";

                if (this.itemName.Text != "") addingSQL += " AND " + this.comboSearchType.Text + " LIKE '%" + this.itemName.Text + "%' ";

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

                this.items.ItemTemplate.Clear();
                while (reader.Read())
                {
                    ItemTemplates.ItemTemplateRow row = items.ItemTemplate.NewItemTemplateRow();
                    row.Id_nb = reader.GetString("Id_nb");
                    row.Name = reader.GetString("Name");
                    row.Level = reader.GetInt32("Level");

                    this.items.ItemTemplate.Rows.Add(row);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mainForm.mysqlConnection.Close();
            }
        }

        private void searchItems(object sender, EventArgs e)
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

        private void reloadData(object sender, EventArgs e)
        {
            getTableData((int)this.current_page.Value);
        }

        private void selectItem()
        {
            if (itemDataGrid.SelectedRows.Count > 0)
            {
                selectedItemKeyname = Convert.ToString(itemDataGrid.SelectedRows[0].Cells[0].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else selectedItemKeyname = "";
        }

        private void selectItemButton_Click(object sender, EventArgs e)
        {
            selectItem();
        }

        private void itemDataGrid_Enter(object sender, EventArgs e)
        {
            this.selectItemButton.Enabled = true;
        }
    }
}