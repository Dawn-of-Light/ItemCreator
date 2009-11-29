namespace ItemCreator
{
    partial class newModelChooser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newModelChooser));
            this.search_model_groupbox = new System.Windows.Forms.GroupBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.model_preview_checkbox = new System.Windows.Forms.CheckBox();
            this.model_expansion_selectbox = new System.Windows.Forms.ComboBox();
            this.itemModels = new ItemCreator.database.ItemModels();
            this.label3 = new System.Windows.Forms.Label();
            this.model_category_selectbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.model_name_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.model_preview_picturebox = new System.Windows.Forms.PictureBox();
            this.loading_worker = new System.ComponentModel.BackgroundWorker();
            this.select_model_button = new System.Windows.Forms.Button();
            this.loading_panel = new System.Windows.Forms.Panel();
            this.loading_label = new System.Windows.Forms.Label();
            this.loading_progressbar = new System.Windows.Forms.ProgressBar();
            this.model_datagrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expansionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preview = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loading_timer = new System.Windows.Forms.Timer(this.components);
            this.search_model_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_preview_picturebox)).BeginInit();
            this.loading_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // search_model_groupbox
            // 
            this.search_model_groupbox.AccessibleDescription = null;
            this.search_model_groupbox.AccessibleName = null;
            resources.ApplyResources(this.search_model_groupbox, "search_model_groupbox");
            this.search_model_groupbox.BackgroundImage = null;
            this.search_model_groupbox.Controls.Add(this.reset_button);
            this.search_model_groupbox.Controls.Add(this.search_button);
            this.search_model_groupbox.Controls.Add(this.model_preview_checkbox);
            this.search_model_groupbox.Controls.Add(this.model_expansion_selectbox);
            this.search_model_groupbox.Controls.Add(this.label3);
            this.search_model_groupbox.Controls.Add(this.model_category_selectbox);
            this.search_model_groupbox.Controls.Add(this.label2);
            this.search_model_groupbox.Controls.Add(this.model_name_textbox);
            this.search_model_groupbox.Controls.Add(this.label1);
            this.search_model_groupbox.Font = null;
            this.search_model_groupbox.Name = "search_model_groupbox";
            this.search_model_groupbox.TabStop = false;
            // 
            // reset_button
            // 
            this.reset_button.AccessibleDescription = null;
            this.reset_button.AccessibleName = null;
            resources.ApplyResources(this.reset_button, "reset_button");
            this.reset_button.BackgroundImage = null;
            this.reset_button.Font = null;
            this.reset_button.Name = "reset_button";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // search_button
            // 
            this.search_button.AccessibleDescription = null;
            this.search_button.AccessibleName = null;
            resources.ApplyResources(this.search_button, "search_button");
            this.search_button.BackgroundImage = null;
            this.search_button.Name = "search_button";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_models);
            // 
            // model_preview_checkbox
            // 
            this.model_preview_checkbox.AccessibleDescription = null;
            this.model_preview_checkbox.AccessibleName = null;
            resources.ApplyResources(this.model_preview_checkbox, "model_preview_checkbox");
            this.model_preview_checkbox.BackgroundImage = null;
            this.model_preview_checkbox.Checked = true;
            this.model_preview_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.model_preview_checkbox.Font = null;
            this.model_preview_checkbox.Name = "model_preview_checkbox";
            this.model_preview_checkbox.UseVisualStyleBackColor = true;
            this.model_preview_checkbox.CheckedChanged += new System.EventHandler(this.model_preview_checkbox_CheckedChanged);
            // 
            // model_expansion_selectbox
            // 
            this.model_expansion_selectbox.AccessibleDescription = null;
            this.model_expansion_selectbox.AccessibleName = null;
            resources.ApplyResources(this.model_expansion_selectbox, "model_expansion_selectbox");
            this.model_expansion_selectbox.BackgroundImage = null;
            this.model_expansion_selectbox.DataSource = this.itemModels;
            this.model_expansion_selectbox.DisplayMember = "Expansions.name";
            this.model_expansion_selectbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_expansion_selectbox.Font = null;
            this.model_expansion_selectbox.FormattingEnabled = true;
            this.model_expansion_selectbox.Name = "model_expansion_selectbox";
            this.model_expansion_selectbox.ValueMember = "Expansions.id";
            this.model_expansion_selectbox.SelectedIndexChanged += new System.EventHandler(this.search_models);
            // 
            // itemModels
            // 
            this.itemModels.DataSetName = "ItemModels";
            this.itemModels.Locale = new System.Globalization.CultureInfo("");
            this.itemModels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // model_category_selectbox
            // 
            this.model_category_selectbox.AccessibleDescription = null;
            this.model_category_selectbox.AccessibleName = null;
            resources.ApplyResources(this.model_category_selectbox, "model_category_selectbox");
            this.model_category_selectbox.BackgroundImage = null;
            this.model_category_selectbox.DataSource = this.itemModels;
            this.model_category_selectbox.DisplayMember = "Categories.name";
            this.model_category_selectbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_category_selectbox.Font = null;
            this.model_category_selectbox.FormattingEnabled = true;
            this.model_category_selectbox.Name = "model_category_selectbox";
            this.model_category_selectbox.ValueMember = "Categories.id";
            this.model_category_selectbox.SelectedIndexChanged += new System.EventHandler(this.search_models);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // model_name_textbox
            // 
            this.model_name_textbox.AccessibleDescription = null;
            this.model_name_textbox.AccessibleName = null;
            resources.ApplyResources(this.model_name_textbox, "model_name_textbox");
            this.model_name_textbox.BackgroundImage = null;
            this.model_name_textbox.Font = null;
            this.model_name_textbox.Name = "model_name_textbox";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // model_preview_picturebox
            // 
            this.model_preview_picturebox.AccessibleDescription = null;
            this.model_preview_picturebox.AccessibleName = null;
            resources.ApplyResources(this.model_preview_picturebox, "model_preview_picturebox");
            this.model_preview_picturebox.BackgroundImage = null;
            this.model_preview_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.model_preview_picturebox.ErrorImage = global::ItemCreator.Properties.Resources.dol;
            this.model_preview_picturebox.Font = null;
            this.model_preview_picturebox.Image = global::ItemCreator.Properties.Resources.dol;
            this.model_preview_picturebox.ImageLocation = null;
            this.model_preview_picturebox.InitialImage = global::ItemCreator.Properties.Resources.dol;
            this.model_preview_picturebox.Name = "model_preview_picturebox";
            this.model_preview_picturebox.TabStop = false;
            this.model_preview_picturebox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.model_preview_picturebox_LoadCompleted);
            // 
            // select_model_button
            // 
            this.select_model_button.AccessibleDescription = null;
            this.select_model_button.AccessibleName = null;
            resources.ApplyResources(this.select_model_button, "select_model_button");
            this.select_model_button.BackgroundImage = null;
            this.select_model_button.Font = null;
            this.select_model_button.Name = "select_model_button";
            this.select_model_button.UseVisualStyleBackColor = true;
            this.select_model_button.Click += new System.EventHandler(this.select_model_button_Click);
            // 
            // loading_panel
            // 
            this.loading_panel.AccessibleDescription = null;
            this.loading_panel.AccessibleName = null;
            resources.ApplyResources(this.loading_panel, "loading_panel");
            this.loading_panel.BackgroundImage = null;
            this.loading_panel.Controls.Add(this.loading_label);
            this.loading_panel.Controls.Add(this.loading_progressbar);
            this.loading_panel.Font = null;
            this.loading_panel.Name = "loading_panel";
            // 
            // loading_label
            // 
            this.loading_label.AccessibleDescription = null;
            this.loading_label.AccessibleName = null;
            resources.ApplyResources(this.loading_label, "loading_label");
            this.loading_label.Font = null;
            this.loading_label.Name = "loading_label";
            // 
            // loading_progressbar
            // 
            this.loading_progressbar.AccessibleDescription = null;
            this.loading_progressbar.AccessibleName = null;
            resources.ApplyResources(this.loading_progressbar, "loading_progressbar");
            this.loading_progressbar.BackgroundImage = null;
            this.loading_progressbar.Font = null;
            this.loading_progressbar.Name = "loading_progressbar";
            this.loading_progressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // model_datagrid
            // 
            this.model_datagrid.AccessibleDescription = null;
            this.model_datagrid.AccessibleName = null;
            this.model_datagrid.AllowUserToAddRows = false;
            this.model_datagrid.AllowUserToDeleteRows = false;
            this.model_datagrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.model_datagrid, "model_datagrid");
            this.model_datagrid.AutoGenerateColumns = false;
            this.model_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.model_datagrid.BackgroundImage = null;
            this.model_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.model_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.expansionDataGridViewTextBoxColumn,
            this.Preview});
            this.model_datagrid.DataMember = "Models";
            this.model_datagrid.DataSource = this.itemModels;
            this.model_datagrid.Font = null;
            this.model_datagrid.MultiSelect = false;
            this.model_datagrid.Name = "model_datagrid";
            this.model_datagrid.ReadOnly = true;
            this.model_datagrid.RowHeadersVisible = false;
            this.model_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.model_datagrid.ShowCellErrors = false;
            this.model_datagrid.ShowEditingIcon = false;
            this.model_datagrid.ShowRowErrors = false;
            this.model_datagrid.VirtualMode = true;
            this.model_datagrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.model_datagrid_RowEnter);
            this.model_datagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.model_datagrid_CellMouseDoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 10F;
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 30F;
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.FillWeight = 25F;
            resources.ApplyResources(this.categoryDataGridViewTextBoxColumn, "categoryDataGridViewTextBoxColumn");
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expansionDataGridViewTextBoxColumn
            // 
            this.expansionDataGridViewTextBoxColumn.DataPropertyName = "Expansion";
            this.expansionDataGridViewTextBoxColumn.FillWeight = 23F;
            resources.ApplyResources(this.expansionDataGridViewTextBoxColumn, "expansionDataGridViewTextBoxColumn");
            this.expansionDataGridViewTextBoxColumn.Name = "expansionDataGridViewTextBoxColumn";
            this.expansionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Preview
            // 
            this.Preview.DataPropertyName = "Preview";
            this.Preview.FillWeight = 12F;
            resources.ApplyResources(this.Preview, "Preview");
            this.Preview.Name = "Preview";
            this.Preview.ReadOnly = true;
            // 
            // loading_timer
            // 
            this.loading_timer.Interval = 500;
            this.loading_timer.Tick += new System.EventHandler(this.loading_timer_Tick);
            // 
            // newModelChooser
            // 
            this.AcceptButton = this.search_button;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.loading_panel);
            this.Controls.Add(this.select_model_button);
            this.Controls.Add(this.model_preview_picturebox);
            this.Controls.Add(this.model_datagrid);
            this.Controls.Add(this.search_model_groupbox);
            this.Font = null;
            this.MinimizeBox = false;
            this.Name = "newModelChooser";
            this.ShowInTaskbar = false;
            this.search_model_groupbox.ResumeLayout(false);
            this.search_model_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_preview_picturebox)).EndInit();
            this.loading_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.model_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox search_model_groupbox;
        private System.Windows.Forms.TextBox model_name_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox model_category_selectbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.CheckBox model_preview_checkbox;
        private System.Windows.Forms.ComboBox model_expansion_selectbox;
        private System.Windows.Forms.DataGridView model_datagrid;
        private System.Windows.Forms.PictureBox model_preview_picturebox;
        private ItemCreator.database.ItemModels itemModels;
        private System.ComponentModel.BackgroundWorker loading_worker;
        private System.Windows.Forms.Button select_model_button;
        private System.Windows.Forms.Panel loading_panel;
        private System.Windows.Forms.Label loading_label;
        private System.Windows.Forms.ProgressBar loading_progressbar;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Timer loading_timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expansionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Preview;
    }
}