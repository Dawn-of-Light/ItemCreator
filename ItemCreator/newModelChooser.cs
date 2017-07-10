using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using ItemCreator.database;

using System.Linq;

namespace ItemCreator
{
    public partial class newModelChooser : Form
    {
        private string xmlfile = Application.StartupPath + Path.DirectorySeparatorChar + "database" + Path.DirectorySeparatorChar + "models.xml";

        private int _selectedModelId = 0;
        public int selectedModelId
        {
            get { return _selectedModelId; }
            set { _selectedModelId = value; }
        }

        public newModelChooser(int initialModel)
        {
            InitializeComponent();

            if (initialModel > 0)
            {
                this.selectedModelId = initialModel;
            }

            //Loading data asynchronous to avoid freezes
            this.loading_panel.Visible = true;
            this.loading_worker.DoWork += new DoWorkEventHandler(loadData_progress);
            this.loading_worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(loadData_progress_complete);
            this.loading_worker.RunWorkerAsync();
        }

        #region Loading

        /// <summary>
        /// Loads data from file asychronous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadData_progress(object sender, DoWorkEventArgs e)
        {
            e.Result = loadData();
        }

        /// <summary>
        /// Completes the initial loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadData_progress_complete(object sender, RunWorkerCompletedEventArgs e)
        {
            this.itemModels.Clear();
            this.itemModels.Merge((ItemModels)e.Result);

            if (this.selectedModelId > 0)
            {
                int rowIndex = 0;
                foreach (DataGridViewRow row in this.model_datagrid.Rows)
                {
                    if (row.Cells["iDDataGridViewTextBoxColumn"].Value.Equals(this.selectedModelId))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }

                this.model_datagrid.FirstDisplayedScrollingRowIndex = rowIndex;
                this.model_datagrid.Refresh();
                this.model_datagrid.CurrentCell = this.model_datagrid.Rows[rowIndex].Cells[0];
                this.model_datagrid.Rows[rowIndex].Selected = true;
            }

            this.loading_panel.Visible = false;
        }

        /// <summary>
        /// If the source file id not found, an empty one will be created
        /// </summary>
        /// <returns></returns>
        private ItemModels createEmptyDataList()
        {
            this.itemModels.WriteXml(xmlfile);
            return loadData();
        }

        /// <summary>
        /// Loads the source data into a DataSet
        /// </summary>
        /// <returns>DataSet with model data</returns>
        private ItemModels loadData()
        {
            if (System.IO.File.Exists(xmlfile))
            {
                ItemModels models = new ItemModels();
                models.ReadXml(xmlfile);
                return models;
            }
            else return createEmptyDataList();
        }

        #endregion

        #region Select Model ID

        /// <summary>
        /// Select a model id by doubleclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void model_datagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.selectModelId(e.RowIndex);
        }

        /// <summary>
        /// Select a model id button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void select_model_button_Click(object sender, EventArgs e)
        {
            if (this.model_datagrid.SelectedRows.Count > 0)
            {
                this.selectModelId(this.model_datagrid.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Selects the model and return it
        /// </summary>
        /// <param name="rowIndex">Row index of the model</param>
        private void selectModelId(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= this.itemModels.Models.Count) return;

            selectedModelId = Convert.ToInt32(this.model_datagrid.Rows[rowIndex].Cells["iDDataGridViewTextBoxColumn"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Searching

        /// <summary>
        /// Searchbutton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_models(object sender, EventArgs e)
        {
            string model_name = this.model_name_textbox.Text;
            string model_category = this.model_category_selectbox.SelectedValue.ToString();
            string model_expansion = this.model_expansion_selectbox.SelectedValue.ToString();

            ItemModels.ModelsDataTable models = this.selectData(model_name, model_category, model_expansion);
            this.model_datagrid.DataSource = models;
        }

        /// <summary>
        /// Resets the sarch form to its defaults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_button_Click(object sender, EventArgs e)
        {
            this.model_datagrid.DataSource = this.itemModels.Models;
            this.model_name_textbox.Text = "";
            this.model_category_selectbox.SelectedIndex = 0;
            this.model_expansion_selectbox.SelectedIndex = 0;
        }

        /// <summary>
        /// Performs search action and return the new DataTable
        /// </summary>
        /// <param name="name">Search for a name</param>
        /// <param name="category">Search by category</param>
        /// <param name="expansion">Search by Expansion</param>
        /// <returns>DataTable with search results</returns>
        private ItemModels.ModelsDataTable selectData(string name, string category, string expansion)
        {
            name = name.ToLower().Trim();

            var query = from
                            m
                        in
                            itemModels.Models
                        select
                            new { m.ID, m.Name, m.Category, m.Expansion, m.Preview };

            if (name.Length > 0)
            {
                query = query.Where(m => m.Name.ToLower().Contains(name));
            }
            if (category.Length > 0 && category != "all")
            {
                query = query.Where(m => m.Category == category);
            }
            if (expansion.Length > 0 && expansion != "all")
            {
                query = query.Where(m => m.Expansion == expansion);
            }

            //Create a new table for bindings
            ItemModels.ModelsDataTable models = new ItemModels.ModelsDataTable();

            foreach (var row in query)
            {
                models.Rows.Add(row.ID, row.Name, row.Category, row.Expansion, row.Preview);
            }

            return models;
        }

        #endregion

        #region preview feature

        /// <summary>
        /// Checkbox event if preview window will be filled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void model_preview_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked) this.model_preview_picturebox.Image = this.model_preview_picturebox.InitialImage;
        }

        /// <summary>
        /// Loads an image in row enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void model_datagrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!this.model_preview_checkbox.Checked) return;

            if(this.loading_timer.Enabled) this.loading_timer.Stop();
            this.loading_timer.Start();
        }

        /// <summary>
        /// After a duration of 0.5 seconds the image will be loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void loading_timer_Tick(object sender, EventArgs e)
        {
            this.loading_timer.Stop();
            if (this.model_datagrid.SelectedRows.Count == 0) return;

            try
            {
                int modelId = (int)this.model_datagrid.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value;
                ItemModels.ModelsRow row = (from m in this.itemModels.Models where m.ID == modelId select m).Single<ItemModels.ModelsRow>();
                this.load_model_image(row);
            }
            catch {}
        }

        /// <summary>
        /// Loading finished event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void model_preview_picturebox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.loading_panel.Visible = false;
        }

        /// <summary>
        /// The current shown image
        /// </summary>
        private int current_loaded_image = 0;

        /// <summary>
        /// Finally loads an Image
        /// </summary>
        /// <param name="row"></param>
        private void load_model_image(ItemModels.ModelsRow row)
        {
            //Same Model chosen, do not load
            if (this.current_loaded_image == row.ID) return;
            //Not categoized, generally no preview available
            //OR Generally no preview available
            if (row.Category.Length == 0 || !row.Preview)
            {
                this.model_preview_picturebox.Image = this.model_preview_picturebox.InitialImage;
                return;
            }

            this.loading_panel.Visible = true;

			string base_url = @"http://herald.uthgard.net/daoc/list.php?img=items|" + row.ID;

            this.model_preview_picturebox.ImageLocation = base_url;
            this.current_loaded_image = row.ID;
        }

        #endregion

        
    }
}
