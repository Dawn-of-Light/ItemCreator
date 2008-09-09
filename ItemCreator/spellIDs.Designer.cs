namespace ItemCreator
{
    partial class spellIDs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spellIDs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectSpellButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.targetComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.spellName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.current_page = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pages_total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spellDataGrid = new System.Windows.Forms.DataGridView();
            this.spellList = new ItemCreator.database.Spells();
            this.label6 = new System.Windows.Forms.Label();
            this.order_by = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.data_per_page = new System.Windows.Forms.ComboBox();
            this.spellIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_page)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellList)).BeginInit();
            this.SuspendLayout();
            // 
            // selectSpellButton
            // 
            this.selectSpellButton.AccessibleDescription = null;
            this.selectSpellButton.AccessibleName = null;
            resources.ApplyResources(this.selectSpellButton, "selectSpellButton");
            this.selectSpellButton.BackgroundImage = null;
            this.selectSpellButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.selectSpellButton.Font = null;
            this.selectSpellButton.Name = "selectSpellButton";
            this.selectSpellButton.UseVisualStyleBackColor = true;
            this.selectSpellButton.Click += new System.EventHandler(this.selectSpellButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.typesComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.targetComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.spellName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.AccessibleDescription = null;
            this.searchButton.AccessibleName = null;
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.BackgroundImage = null;
            this.searchButton.Font = null;
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchSpells);
            // 
            // typesComboBox
            // 
            this.typesComboBox.AccessibleDescription = null;
            this.typesComboBox.AccessibleName = null;
            resources.ApplyResources(this.typesComboBox, "typesComboBox");
            this.typesComboBox.BackgroundImage = null;
            this.typesComboBox.Font = null;
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Sorted = true;
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Font = null;
            this.label5.Name = "label5";
            // 
            // targetComboBox
            // 
            this.targetComboBox.AccessibleDescription = null;
            this.targetComboBox.AccessibleName = null;
            resources.ApplyResources(this.targetComboBox, "targetComboBox");
            this.targetComboBox.BackgroundImage = null;
            this.targetComboBox.Font = null;
            this.targetComboBox.FormattingEnabled = true;
            this.targetComboBox.Name = "targetComboBox";
            this.targetComboBox.Sorted = true;
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
            // 
            // spellName
            // 
            this.spellName.AccessibleDescription = null;
            this.spellName.AccessibleName = null;
            resources.ApplyResources(this.spellName, "spellName");
            this.spellName.BackgroundImage = null;
            this.spellName.Font = null;
            this.spellName.Name = "spellName";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // current_page
            // 
            this.current_page.AccessibleDescription = null;
            this.current_page.AccessibleName = null;
            resources.ApplyResources(this.current_page, "current_page");
            this.current_page.Font = null;
            this.current_page.Name = "current_page";
            this.current_page.ReadOnly = true;
            this.current_page.ValueChanged += new System.EventHandler(this.current_page_ValueChanged);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // pages_total
            // 
            this.pages_total.AccessibleDescription = null;
            this.pages_total.AccessibleName = null;
            resources.ApplyResources(this.pages_total, "pages_total");
            this.pages_total.Font = null;
            this.pages_total.Name = "pages_total";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // spellDataGrid
            // 
            this.spellDataGrid.AccessibleDescription = null;
            this.spellDataGrid.AccessibleName = null;
            this.spellDataGrid.AllowUserToAddRows = false;
            this.spellDataGrid.AllowUserToDeleteRows = false;
            this.spellDataGrid.AllowUserToOrderColumns = true;
            this.spellDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.spellDataGrid, "spellDataGrid");
            this.spellDataGrid.AutoGenerateColumns = false;
            this.spellDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spellDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.spellDataGrid.BackgroundImage = null;
            this.spellDataGrid.CausesValidation = false;
            this.spellDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.spellDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.spellDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spellIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.spellDataGrid.DataMember = "Spell";
            this.spellDataGrid.DataSource = this.spellList;
            this.spellDataGrid.Font = null;
            this.spellDataGrid.MultiSelect = false;
            this.spellDataGrid.Name = "spellDataGrid";
            this.spellDataGrid.ReadOnly = true;
            this.spellDataGrid.RowHeadersVisible = false;
            this.spellDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.spellDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.spellDataGrid.ShowCellErrors = false;
            this.spellDataGrid.ShowCellToolTips = false;
            this.spellDataGrid.ShowEditingIcon = false;
            this.spellDataGrid.ShowRowErrors = false;
            this.spellDataGrid.VirtualMode = true;
            this.spellDataGrid.Enter += new System.EventHandler(this.spellDataGrid_Enter);
            this.spellDataGrid.DoubleClick += new System.EventHandler(this.selectSpellButton_Click);
            // 
            // spellList
            // 
            this.spellList.DataSetName = "Spells";
            this.spellList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Font = null;
            this.label6.Name = "label6";
            // 
            // order_by
            // 
            this.order_by.AccessibleDescription = null;
            this.order_by.AccessibleName = null;
            resources.ApplyResources(this.order_by, "order_by");
            this.order_by.BackgroundImage = null;
            this.order_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order_by.Font = null;
            this.order_by.FormattingEnabled = true;
            this.order_by.Items.AddRange(new object[] {
            resources.GetString("order_by.Items"),
            resources.GetString("order_by.Items1"),
            resources.GetString("order_by.Items2"),
            resources.GetString("order_by.Items3"),
            resources.GetString("order_by.Items4"),
            resources.GetString("order_by.Items5")});
            this.order_by.Name = "order_by";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Font = null;
            this.label7.Name = "label7";
            // 
            // data_per_page
            // 
            this.data_per_page.AccessibleDescription = null;
            this.data_per_page.AccessibleName = null;
            resources.ApplyResources(this.data_per_page, "data_per_page");
            this.data_per_page.BackgroundImage = null;
            this.data_per_page.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.data_per_page.Font = null;
            this.data_per_page.FormattingEnabled = true;
            this.data_per_page.Items.AddRange(new object[] {
            resources.GetString("data_per_page.Items"),
            resources.GetString("data_per_page.Items1"),
            resources.GetString("data_per_page.Items2")});
            this.data_per_page.Name = "data_per_page";
            // 
            // spellIDDataGridViewTextBoxColumn
            // 
            this.spellIDDataGridViewTextBoxColumn.DataPropertyName = "SpellID";
            this.spellIDDataGridViewTextBoxColumn.FillWeight = 10F;
            resources.ApplyResources(this.spellIDDataGridViewTextBoxColumn, "spellIDDataGridViewTextBoxColumn");
            this.spellIDDataGridViewTextBoxColumn.Name = "spellIDDataGridViewTextBoxColumn";
            this.spellIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 60F;
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.FillWeight = 20F;
            resources.ApplyResources(this.targetDataGridViewTextBoxColumn, "targetDataGridViewTextBoxColumn");
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            this.targetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.FillWeight = 30F;
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 10F;
            resources.ApplyResources(this.valueDataGridViewTextBoxColumn, "valueDataGridViewTextBoxColumn");
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spellIDs
            // 
            this.AcceptButton = this.searchButton;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.data_per_page);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.order_by);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spellDataGrid);
            this.Controls.Add(this.pages_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.current_page);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectSpellButton);
            this.Font = null;
            this.MinimizeBox = false;
            this.Name = "spellIDs";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_page)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectSpellButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox spellName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown current_page;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pages_total;
        private System.Windows.Forms.DataGridView spellDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox targetComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.Label label5;
        private ItemCreator.database.Spells spellList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox order_by;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox data_per_page;
        private System.Windows.Forms.DataGridViewTextBoxColumn spellIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}