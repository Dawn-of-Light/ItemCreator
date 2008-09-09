using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wilson.XmlDbClient;
using System.Threading;
using ItemCreator.database;

namespace ItemCreator
{
    public partial class modelIds : Form
    {
        private string xmlfile = Application.StartupPath + "//database/models.xml";

        private int _selectedModelId = 0;
        public int selectedModelId
        {
            get { return _selectedModelId; }
            set { _selectedModelId = value; }
        }

        public modelIds()
        {
            InitializeComponent();
            loadData();
        }

        private void createEmptyDataList()
        {
            itemModels.WriteXml(xmlfile);
            loadData();
        }

        private void loadData()
        {
            if (System.IO.File.Exists(xmlfile) == true)
            {
                foreach (DataTable dataTable in itemModels.Tables) dataTable.BeginLoadData();
                itemModels.ReadXml(xmlfile);
                foreach (DataTable dataTable in itemModels.Tables) dataTable.EndLoadData();
            }
            else createEmptyDataList();
        }

        private void searchData(string keywords, string category, string expansion)
        {
            bool added = false;
            string SQL = "SELECT ID, Name, Category, Expansion FROM Models WHERE ";

            if (keywords != null)
            {
                //Special thingy for Keywords
                string[] newKeys = keywords.Split(Convert.ToChar(" "));
                SQL += " (";
                for (int i = 0; i < newKeys.Length; i++)
                {
                    if (i == 0) SQL += " Name LIKE '%" + newKeys[i] + "%'";
                    else SQL += " AND Name LIKE '%" + newKeys[i] + "%'";
                }
                SQL += ") ";

                added = true;
            }
            if (category != null)
            {
                if (added == true) SQL += " AND Category = '" + category + "' ";
                else
                {
                    added = true;
                    SQL += " Category = '" + category + "' ";
                }
            }
            if (expansion != null)
            {
                if (added == true) SQL += " AND Expansion = '" + expansion + "' ";
                else
                {
                    added = true;
                    SQL += " Expansion = '" + expansion + "' ";
                }
            }
            //MessageBox.Show(SQL);
            XmlDbConnection connect = null;
            try
            {
                connect = new XmlDbConnection(xmlfile);
                IDbDataAdapter adapter = new XmlDbDataAdapter(new XmlDbCommand(SQL, connect));
                itemModels.Tables["Models"].Clear();
                adapter.Fill(itemModels);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (connect != null) connect.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            selectButton.Enabled = false;
            
            string keywords = (searchName.Text != "") ? searchName.Text : null;
            string category = (searchCategory.SelectedValue.ToString() != "") ? searchCategory.SelectedValue.ToString() : null;
            string expansion = (searchExpansion.SelectedValue.ToString() != "") ? searchExpansion.SelectedValue.ToString() : null;
            
            if(keywords != null || category != null || expansion != null) searchData(keywords, category, expansion);
        }

        private void modelDataGrid_Enter(object sender, EventArgs e)
        {
            if (modelDataGrid.SelectedRows.Count > 0) selectButton.Enabled = true;
        }

        private void modelDataGrid_DoubleClick(object sender, EventArgs e)
        {
            selectModelId();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            selectModelId();
        }

        private void selectModelId()
        {
            if(modelDataGrid.SelectedRows.Count > 0) 
            {
                selectedModelId = (int) modelDataGrid.SelectedRows[0].Cells[0].Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else selectedModelId = 0; 
        }
    }
}