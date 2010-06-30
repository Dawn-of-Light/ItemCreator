namespace ItemCreator
{
    partial class mysqlItems
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mysqlItems));
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.comboSearchType = new System.Windows.Forms.ComboBox();
        	this.searchButton = new System.Windows.Forms.Button();
        	this.itemName = new System.Windows.Forms.TextBox();
        	this.itemDataGrid = new System.Windows.Forms.DataGridView();
        	this.idnbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.items = new ItemCreator.database.ItemTemplates();
        	this.selectItemButton = new System.Windows.Forms.Button();
        	this.data_per_page = new System.Windows.Forms.ComboBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.order_by = new System.Windows.Forms.ComboBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.pages_total = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.current_page = new System.Windows.Forms.NumericUpDown();
        	this.groupBox1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.current_page)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.comboSearchType);
        	this.groupBox1.Controls.Add(this.searchButton);
        	this.groupBox1.Controls.Add(this.itemName);
        	resources.ApplyResources(this.groupBox1, "groupBox1");
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.TabStop = false;
        	// 
        	// comboSearchType
        	// 
        	this.comboSearchType.FormattingEnabled = true;
        	this.comboSearchType.Items.AddRange(new object[] {
        	        	        	resources.GetString("comboSearchType.Items"),
        	        	        	resources.GetString("comboSearchType.Items1"),
        	        	        	resources.GetString("comboSearchType.Items2")});
        	resources.ApplyResources(this.comboSearchType, "comboSearchType");
        	this.comboSearchType.Name = "comboSearchType";
        	// 
        	// searchButton
        	// 
        	resources.ApplyResources(this.searchButton, "searchButton");
        	this.searchButton.Name = "searchButton";
        	this.searchButton.UseVisualStyleBackColor = true;
        	this.searchButton.Click += new System.EventHandler(this.searchItems);
        	// 
        	// itemName
        	// 
        	resources.ApplyResources(this.itemName, "itemName");
        	this.itemName.Name = "itemName";
        	// 
        	// itemDataGrid
        	// 
        	this.itemDataGrid.AllowUserToAddRows = false;
        	this.itemDataGrid.AllowUserToDeleteRows = false;
        	this.itemDataGrid.AllowUserToOrderColumns = true;
        	this.itemDataGrid.AllowUserToResizeRows = false;
        	resources.ApplyResources(this.itemDataGrid, "itemDataGrid");
        	this.itemDataGrid.AutoGenerateColumns = false;
        	this.itemDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.itemDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        	this.itemDataGrid.CausesValidation = false;
        	this.itemDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
        	this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        	this.itemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        	        	        	this.idnbDataGridViewTextBoxColumn,
        	        	        	this.nameDataGridViewTextBoxColumn,
        	        	        	this.levelDataGridViewTextBoxColumn});
        	this.itemDataGrid.DataMember = "ItemTemplate";
        	this.itemDataGrid.DataSource = this.items;
        	this.itemDataGrid.MultiSelect = false;
        	this.itemDataGrid.Name = "itemDataGrid";
        	this.itemDataGrid.ReadOnly = true;
        	this.itemDataGrid.RowHeadersVisible = false;
        	this.itemDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        	this.itemDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.itemDataGrid.ShowCellErrors = false;
        	this.itemDataGrid.ShowCellToolTips = false;
        	this.itemDataGrid.ShowEditingIcon = false;
        	this.itemDataGrid.ShowRowErrors = false;
        	this.itemDataGrid.VirtualMode = true;
        	this.itemDataGrid.Enter += new System.EventHandler(this.itemDataGrid_Enter);
        	this.itemDataGrid.DoubleClick += new System.EventHandler(this.selectItemButton_Click);
        	// 
        	// idnbDataGridViewTextBoxColumn
        	// 
        	this.idnbDataGridViewTextBoxColumn.DataPropertyName = "Id_nb";
        	this.idnbDataGridViewTextBoxColumn.FillWeight = 40F;
        	resources.ApplyResources(this.idnbDataGridViewTextBoxColumn, "idnbDataGridViewTextBoxColumn");
        	this.idnbDataGridViewTextBoxColumn.Name = "idnbDataGridViewTextBoxColumn";
        	this.idnbDataGridViewTextBoxColumn.ReadOnly = true;
        	// 
        	// nameDataGridViewTextBoxColumn
        	// 
        	this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
        	resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
        	this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
        	this.nameDataGridViewTextBoxColumn.ReadOnly = true;
        	// 
        	// levelDataGridViewTextBoxColumn
        	// 
        	this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
        	this.levelDataGridViewTextBoxColumn.FillWeight = 15F;
        	resources.ApplyResources(this.levelDataGridViewTextBoxColumn, "levelDataGridViewTextBoxColumn");
        	this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
        	this.levelDataGridViewTextBoxColumn.ReadOnly = true;
        	// 
        	// items
        	// 
        	this.items.DataSetName = "ItemTemplates";
        	this.items.Namespace = "http://dol.oecken.net/ItemCreator/schemas/ItemTemplates.xsd";
        	this.items.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        	// 
        	// selectItemButton
        	// 
        	resources.ApplyResources(this.selectItemButton, "selectItemButton");
        	this.selectItemButton.Name = "selectItemButton";
        	this.selectItemButton.UseVisualStyleBackColor = true;
        	this.selectItemButton.Click += new System.EventHandler(this.selectItemButton_Click);
        	// 
        	// data_per_page
        	// 
        	this.data_per_page.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.data_per_page.FormattingEnabled = true;
        	this.data_per_page.Items.AddRange(new object[] {
        	        	        	resources.GetString("data_per_page.Items"),
        	        	        	resources.GetString("data_per_page.Items1"),
        	        	        	resources.GetString("data_per_page.Items2")});
        	resources.ApplyResources(this.data_per_page, "data_per_page");
        	this.data_per_page.Name = "data_per_page";
        	// 
        	// label7
        	// 
        	resources.ApplyResources(this.label7, "label7");
        	this.label7.Name = "label7";
        	// 
        	// order_by
        	// 
        	this.order_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.order_by.FormattingEnabled = true;
        	this.order_by.Items.AddRange(new object[] {
        	        	        	resources.GetString("order_by.Items"),
        	        	        	resources.GetString("order_by.Items1"),
        	        	        	resources.GetString("order_by.Items2")});
        	resources.ApplyResources(this.order_by, "order_by");
        	this.order_by.Name = "order_by";
        	// 
        	// label6
        	// 
        	resources.ApplyResources(this.label6, "label6");
        	this.label6.Name = "label6";
        	// 
        	// label3
        	// 
        	resources.ApplyResources(this.label3, "label3");
        	this.label3.Name = "label3";
        	// 
        	// pages_total
        	// 
        	resources.ApplyResources(this.pages_total, "pages_total");
        	this.pages_total.Name = "pages_total";
        	// 
        	// label2
        	// 
        	resources.ApplyResources(this.label2, "label2");
        	this.label2.Name = "label2";
        	// 
        	// current_page
        	// 
        	resources.ApplyResources(this.current_page, "current_page");
        	this.current_page.Name = "current_page";
        	this.current_page.ReadOnly = true;
        	this.current_page.ValueChanged += new System.EventHandler(this.current_page_ValueChanged);
        	// 
        	// mysqlItems
        	// 
        	this.AcceptButton = this.searchButton;
        	resources.ApplyResources(this, "$this");
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.data_per_page);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.order_by);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.pages_total);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.current_page);
        	this.Controls.Add(this.selectItemButton);
        	this.Controls.Add(this.itemDataGrid);
        	this.Controls.Add(this.groupBox1);
        	this.MinimizeBox = false;
        	this.Name = "mysqlItems";
        	this.ShowInTaskbar = false;
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.current_page)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ComboBox comboSearchType;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView itemDataGrid;
        private ItemCreator.database.ItemTemplates items;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Button selectItemButton;
        private System.Windows.Forms.ComboBox data_per_page;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox order_by;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pages_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown current_page;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
    }
}