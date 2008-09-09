namespace ItemCreator
{
    partial class updaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updaterForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.updateDatabases = new System.Windows.Forms.Button();
            this.updateApplicationButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versions = new ItemCreator.database.ApplicationVersions();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineversionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkVersionLabel = new System.Windows.Forms.Label();
            this.downloadDatabaseProgressBar = new System.Windows.Forms.ProgressBar();
            this.downloadDatabaseLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.downloadApllicationLabel = new System.Windows.Forms.Label();
            this.downloadApplicationProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // closeButton
            // 
            this.closeButton.AccessibleDescription = null;
            this.closeButton.AccessibleName = null;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackgroundImage = null;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = null;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // updateDatabases
            // 
            this.updateDatabases.AccessibleDescription = null;
            this.updateDatabases.AccessibleName = null;
            resources.ApplyResources(this.updateDatabases, "updateDatabases");
            this.updateDatabases.BackgroundImage = null;
            this.updateDatabases.Font = null;
            this.updateDatabases.Name = "updateDatabases";
            this.updateDatabases.UseVisualStyleBackColor = true;
            this.updateDatabases.Click += new System.EventHandler(this.updateDatabases_Click);
            // 
            // updateApplicationButton
            // 
            this.updateApplicationButton.AccessibleDescription = null;
            this.updateApplicationButton.AccessibleName = null;
            resources.ApplyResources(this.updateApplicationButton, "updateApplicationButton");
            this.updateApplicationButton.BackgroundImage = null;
            this.updateApplicationButton.Font = null;
            this.updateApplicationButton.Name = "updateApplicationButton";
            this.updateApplicationButton.UseVisualStyleBackColor = true;
            this.updateApplicationButton.Click += new System.EventHandler(this.updateApplicationFiles);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleDescription = null;
            this.dataGridView2.AccessibleName = null;
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BackgroundImage = null;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.DataMember = "Application";
            this.dataGridView2.DataSource = this.versions;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Font = null;
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.VirtualMode = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "local_version";
            this.dataGridViewTextBoxColumn2.FillWeight = 30F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "online_version";
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // versions
            // 
            this.versions.DataSetName = "ApplicationVersions";
            this.versions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = null;
            this.dataGridView1.AccessibleName = null;
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BackgroundImage = null;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.update,
            this.filenameDataGridViewTextBoxColumn,
            this.localversionDataGridViewTextBoxColumn,
            this.onlineversionDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Database";
            this.dataGridView1.DataSource = this.versions;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = null;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.VirtualMode = true;
            // 
            // update
            // 
            this.update.DataPropertyName = "update";
            this.update.FillWeight = 10F;
            resources.ApplyResources(this.update, "update");
            this.update.Name = "update";
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            resources.ApplyResources(this.filenameDataGridViewTextBoxColumn, "filenameDataGridViewTextBoxColumn");
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            this.filenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localversionDataGridViewTextBoxColumn
            // 
            this.localversionDataGridViewTextBoxColumn.DataPropertyName = "local_version";
            this.localversionDataGridViewTextBoxColumn.FillWeight = 35F;
            resources.ApplyResources(this.localversionDataGridViewTextBoxColumn, "localversionDataGridViewTextBoxColumn");
            this.localversionDataGridViewTextBoxColumn.Name = "localversionDataGridViewTextBoxColumn";
            this.localversionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onlineversionDataGridViewTextBoxColumn
            // 
            this.onlineversionDataGridViewTextBoxColumn.DataPropertyName = "online_version";
            this.onlineversionDataGridViewTextBoxColumn.FillWeight = 35F;
            resources.ApplyResources(this.onlineversionDataGridViewTextBoxColumn, "onlineversionDataGridViewTextBoxColumn");
            this.onlineversionDataGridViewTextBoxColumn.Name = "onlineversionDataGridViewTextBoxColumn";
            this.onlineversionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkVersionLabel
            // 
            this.checkVersionLabel.AccessibleDescription = null;
            this.checkVersionLabel.AccessibleName = null;
            resources.ApplyResources(this.checkVersionLabel, "checkVersionLabel");
            this.checkVersionLabel.Font = null;
            this.checkVersionLabel.Name = "checkVersionLabel";
            // 
            // downloadDatabaseProgressBar
            // 
            this.downloadDatabaseProgressBar.AccessibleDescription = null;
            this.downloadDatabaseProgressBar.AccessibleName = null;
            resources.ApplyResources(this.downloadDatabaseProgressBar, "downloadDatabaseProgressBar");
            this.downloadDatabaseProgressBar.BackgroundImage = null;
            this.downloadDatabaseProgressBar.Font = null;
            this.downloadDatabaseProgressBar.Name = "downloadDatabaseProgressBar";
            // 
            // downloadDatabaseLabel
            // 
            this.downloadDatabaseLabel.AccessibleDescription = null;
            this.downloadDatabaseLabel.AccessibleName = null;
            resources.ApplyResources(this.downloadDatabaseLabel, "downloadDatabaseLabel");
            this.downloadDatabaseLabel.Font = null;
            this.downloadDatabaseLabel.Name = "downloadDatabaseLabel";
            // 
            // restartLabel
            // 
            this.restartLabel.AccessibleDescription = null;
            this.restartLabel.AccessibleName = null;
            resources.ApplyResources(this.restartLabel, "restartLabel");
            this.restartLabel.Font = null;
            this.restartLabel.Name = "restartLabel";
            // 
            // downloadApllicationLabel
            // 
            this.downloadApllicationLabel.AccessibleDescription = null;
            this.downloadApllicationLabel.AccessibleName = null;
            resources.ApplyResources(this.downloadApllicationLabel, "downloadApllicationLabel");
            this.downloadApllicationLabel.Font = null;
            this.downloadApllicationLabel.Name = "downloadApllicationLabel";
            // 
            // downloadApplicationProgressBar
            // 
            this.downloadApplicationProgressBar.AccessibleDescription = null;
            this.downloadApplicationProgressBar.AccessibleName = null;
            resources.ApplyResources(this.downloadApplicationProgressBar, "downloadApplicationProgressBar");
            this.downloadApplicationProgressBar.BackgroundImage = null;
            this.downloadApplicationProgressBar.Font = null;
            this.downloadApplicationProgressBar.Name = "downloadApplicationProgressBar";
            // 
            // updaterForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.downloadApllicationLabel);
            this.Controls.Add(this.downloadApplicationProgressBar);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.downloadDatabaseLabel);
            this.Controls.Add(this.downloadDatabaseProgressBar);
            this.Controls.Add(this.checkVersionLabel);
            this.Controls.Add(this.updateApplicationButton);
            this.Controls.Add(this.updateDatabases);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updaterForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ItemCreator.database.ApplicationVersions versions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button updateDatabases;
        private System.Windows.Forms.Button updateApplicationButton;
        private System.Windows.Forms.Label checkVersionLabel;
        private System.Windows.Forms.ProgressBar downloadDatabaseProgressBar;
        private System.Windows.Forms.Label downloadDatabaseLabel;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.Label downloadApllicationLabel;
        private System.Windows.Forms.ProgressBar downloadApplicationProgressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn update;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localversionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineversionDataGridViewTextBoxColumn;
    }
}