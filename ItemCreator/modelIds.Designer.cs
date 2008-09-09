namespace ItemCreator
{
    partial class modelIds
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modelIds));
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.searchButton = new System.Windows.Forms.Button();
            this.searchExpansion = new System.Windows.Forms.ComboBox();
            this.expansionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemModels = new ItemCreator.database.ItemModels();
            this.searchCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchName = new System.Windows.Forms.TextBox();
            this.modelDataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expansionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expansionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(this.searchButton);
            groupBox1.Controls.Add(this.searchExpansion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(this.searchCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.searchName);
            groupBox1.Controls.Add(label1);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchExpansion
            // 
            this.searchExpansion.DataSource = this.expansionsBindingSource;
            this.searchExpansion.DisplayMember = "name";
            this.searchExpansion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchExpansion.FormattingEnabled = true;
            resources.ApplyResources(this.searchExpansion, "searchExpansion");
            this.searchExpansion.Name = "searchExpansion";
            this.searchExpansion.ValueMember = "id";
            // 
            // expansionsBindingSource
            // 
            this.expansionsBindingSource.DataMember = "Expansions";
            this.expansionsBindingSource.DataSource = this.itemModels;
            // 
            // itemModels
            // 
            this.itemModels.DataSetName = "ItemModels";
            this.itemModels.Locale = new System.Globalization.CultureInfo("");
            this.itemModels.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // searchCategory
            // 
            this.searchCategory.DataSource = this.categoriesBindingSource;
            this.searchCategory.DisplayMember = "name";
            this.searchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCategory.FormattingEnabled = true;
            resources.ApplyResources(this.searchCategory, "searchCategory");
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.ValueMember = "id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.itemModels;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // searchName
            // 
            resources.ApplyResources(this.searchName, "searchName");
            this.searchName.Name = "searchName";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // modelDataGrid
            // 
            this.modelDataGrid.AllowUserToAddRows = false;
            this.modelDataGrid.AllowUserToDeleteRows = false;
            this.modelDataGrid.AllowUserToOrderColumns = true;
            this.modelDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.modelDataGrid, "modelDataGrid");
            this.modelDataGrid.AutoGenerateColumns = false;
            this.modelDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modelDataGrid.CausesValidation = false;
            this.modelDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.modelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.modelDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.expansionDataGridViewTextBoxColumn});
            this.modelDataGrid.DataSource = this.modelsBindingSource;
            this.modelDataGrid.MultiSelect = false;
            this.modelDataGrid.Name = "modelDataGrid";
            this.modelDataGrid.ReadOnly = true;
            this.modelDataGrid.RowHeadersVisible = false;
            this.modelDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.modelDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modelDataGrid.ShowCellErrors = false;
            this.modelDataGrid.ShowCellToolTips = false;
            this.modelDataGrid.ShowEditingIcon = false;
            this.modelDataGrid.ShowRowErrors = false;
            this.modelDataGrid.VirtualMode = true;
            this.modelDataGrid.Enter += new System.EventHandler(this.modelDataGrid_Enter);
            this.modelDataGrid.DoubleClick += new System.EventHandler(this.modelDataGrid_DoubleClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 20F;
            resources.ApplyResources(this.iDDataGridViewTextBoxColumn, "iDDataGridViewTextBoxColumn");
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.FillWeight = 30F;
            resources.ApplyResources(this.categoryDataGridViewTextBoxColumn, "categoryDataGridViewTextBoxColumn");
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expansionDataGridViewTextBoxColumn
            // 
            this.expansionDataGridViewTextBoxColumn.DataPropertyName = "Expansion";
            this.expansionDataGridViewTextBoxColumn.FillWeight = 30F;
            resources.ApplyResources(this.expansionDataGridViewTextBoxColumn, "expansionDataGridViewTextBoxColumn");
            this.expansionDataGridViewTextBoxColumn.Name = "expansionDataGridViewTextBoxColumn";
            this.expansionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.itemModels;
            // 
            // selectButton
            // 
            resources.ApplyResources(this.selectButton, "selectButton");
            this.selectButton.Name = "selectButton";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // modelIds
            // 
            this.AcceptButton = this.searchButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.modelDataGrid);
            this.Controls.Add(groupBox1);
            this.MinimizeBox = false;
            this.Name = "modelIds";
            this.ShowInTaskbar = false;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expansionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView modelDataGrid;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchExpansion;
        private System.Windows.Forms.ComboBox searchCategory;
        private System.Windows.Forms.Button selectButton;
        private ItemCreator.database.ItemModels itemModels;
        private System.Windows.Forms.BindingSource expansionsBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expansionDataGridViewTextBoxColumn;

    }
}