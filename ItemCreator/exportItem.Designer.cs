namespace ItemCreator
{
    partial class exportItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exportItem));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mysqlTab = new System.Windows.Forms.TabPage();
            this.updateGroup = new System.Windows.Forms.GroupBox();
            this.updateSQLLabel = new System.Windows.Forms.Label();
            this.executeUpdateSQL = new System.Windows.Forms.Button();
            this.insertGroup = new System.Windows.Forms.GroupBox();
            this.insertSQLLabel = new System.Windows.Forms.Label();
            this.executeInsertSQL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mysqlUpdateCodeBox = new System.Windows.Forms.TextBox();
            this.mysqlInsertCodeBox = new System.Windows.Forms.TextBox();
            this.csharpTab = new System.Windows.Forms.TabPage();
            this.csharpCodeBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mysqlTab.SuspendLayout();
            this.updateGroup.SuspendLayout();
            this.insertGroup.SuspendLayout();
            this.csharpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = null;
            this.tabControl1.AccessibleName = null;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.BackgroundImage = null;
            this.tabControl1.Controls.Add(this.mysqlTab);
            this.tabControl1.Controls.Add(this.csharpTab);
            this.tabControl1.Font = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // mysqlTab
            // 
            this.mysqlTab.AccessibleDescription = null;
            this.mysqlTab.AccessibleName = null;
            resources.ApplyResources(this.mysqlTab, "mysqlTab");
            this.mysqlTab.BackgroundImage = null;
            this.mysqlTab.Controls.Add(this.updateGroup);
            this.mysqlTab.Controls.Add(this.insertGroup);
            this.mysqlTab.Controls.Add(this.label2);
            this.mysqlTab.Controls.Add(this.label1);
            this.mysqlTab.Controls.Add(this.mysqlUpdateCodeBox);
            this.mysqlTab.Controls.Add(this.mysqlInsertCodeBox);
            this.mysqlTab.Font = null;
            this.mysqlTab.Name = "mysqlTab";
            this.mysqlTab.UseVisualStyleBackColor = true;
            // 
            // updateGroup
            // 
            this.updateGroup.AccessibleDescription = null;
            this.updateGroup.AccessibleName = null;
            resources.ApplyResources(this.updateGroup, "updateGroup");
            this.updateGroup.BackgroundImage = null;
            this.updateGroup.Controls.Add(this.updateSQLLabel);
            this.updateGroup.Controls.Add(this.executeUpdateSQL);
            this.updateGroup.Font = null;
            this.updateGroup.Name = "updateGroup";
            this.updateGroup.TabStop = false;
            // 
            // updateSQLLabel
            // 
            this.updateSQLLabel.AccessibleDescription = null;
            this.updateSQLLabel.AccessibleName = null;
            resources.ApplyResources(this.updateSQLLabel, "updateSQLLabel");
            this.updateSQLLabel.Font = null;
            this.updateSQLLabel.Name = "updateSQLLabel";
            // 
            // executeUpdateSQL
            // 
            this.executeUpdateSQL.AccessibleDescription = null;
            this.executeUpdateSQL.AccessibleName = null;
            resources.ApplyResources(this.executeUpdateSQL, "executeUpdateSQL");
            this.executeUpdateSQL.BackgroundImage = null;
            this.executeUpdateSQL.Font = null;
            this.executeUpdateSQL.Name = "executeUpdateSQL";
            this.executeUpdateSQL.UseVisualStyleBackColor = true;
            this.executeUpdateSQL.Click += new System.EventHandler(this.executeUpdateSQL_Click);
            // 
            // insertGroup
            // 
            this.insertGroup.AccessibleDescription = null;
            this.insertGroup.AccessibleName = null;
            resources.ApplyResources(this.insertGroup, "insertGroup");
            this.insertGroup.BackgroundImage = null;
            this.insertGroup.Controls.Add(this.insertSQLLabel);
            this.insertGroup.Controls.Add(this.executeInsertSQL);
            this.insertGroup.Font = null;
            this.insertGroup.Name = "insertGroup";
            this.insertGroup.TabStop = false;
            // 
            // insertSQLLabel
            // 
            this.insertSQLLabel.AccessibleDescription = null;
            this.insertSQLLabel.AccessibleName = null;
            resources.ApplyResources(this.insertSQLLabel, "insertSQLLabel");
            this.insertSQLLabel.Font = null;
            this.insertSQLLabel.Name = "insertSQLLabel";
            // 
            // executeInsertSQL
            // 
            this.executeInsertSQL.AccessibleDescription = null;
            this.executeInsertSQL.AccessibleName = null;
            resources.ApplyResources(this.executeInsertSQL, "executeInsertSQL");
            this.executeInsertSQL.BackgroundImage = null;
            this.executeInsertSQL.Font = null;
            this.executeInsertSQL.Name = "executeInsertSQL";
            this.executeInsertSQL.UseVisualStyleBackColor = true;
            this.executeInsertSQL.Click += new System.EventHandler(this.executeInsertSQL_Click);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // mysqlUpdateCodeBox
            // 
            this.mysqlUpdateCodeBox.AccessibleDescription = null;
            this.mysqlUpdateCodeBox.AccessibleName = null;
            resources.ApplyResources(this.mysqlUpdateCodeBox, "mysqlUpdateCodeBox");
            this.mysqlUpdateCodeBox.BackgroundImage = null;
            this.mysqlUpdateCodeBox.Font = null;
            this.mysqlUpdateCodeBox.Name = "mysqlUpdateCodeBox";
            // 
            // mysqlInsertCodeBox
            // 
            this.mysqlInsertCodeBox.AccessibleDescription = null;
            this.mysqlInsertCodeBox.AccessibleName = null;
            resources.ApplyResources(this.mysqlInsertCodeBox, "mysqlInsertCodeBox");
            this.mysqlInsertCodeBox.BackgroundImage = null;
            this.mysqlInsertCodeBox.Font = null;
            this.mysqlInsertCodeBox.Name = "mysqlInsertCodeBox";
            // 
            // csharpTab
            // 
            this.csharpTab.AccessibleDescription = null;
            this.csharpTab.AccessibleName = null;
            resources.ApplyResources(this.csharpTab, "csharpTab");
            this.csharpTab.BackgroundImage = null;
            this.csharpTab.Controls.Add(this.csharpCodeBox);
            this.csharpTab.Font = null;
            this.csharpTab.Name = "csharpTab";
            this.csharpTab.UseVisualStyleBackColor = true;
            // 
            // csharpCodeBox
            // 
            this.csharpCodeBox.AccessibleDescription = null;
            this.csharpCodeBox.AccessibleName = null;
            resources.ApplyResources(this.csharpCodeBox, "csharpCodeBox");
            this.csharpCodeBox.BackgroundImage = null;
            this.csharpCodeBox.Font = null;
            this.csharpCodeBox.Name = "csharpCodeBox";
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
            // exportItem
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = null;
            this.CancelButton = this.closeButton;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tabControl1);
            this.Font = null;
            this.MinimizeBox = false;
            this.Name = "exportItem";
            this.ShowInTaskbar = false;
            this.tabControl1.ResumeLayout(false);
            this.mysqlTab.ResumeLayout(false);
            this.mysqlTab.PerformLayout();
            this.updateGroup.ResumeLayout(false);
            this.insertGroup.ResumeLayout(false);
            this.csharpTab.ResumeLayout(false);
            this.csharpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mysqlTab;
        private System.Windows.Forms.TabPage csharpTab;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox mysqlInsertCodeBox;
        private System.Windows.Forms.TextBox csharpCodeBox;
        private System.Windows.Forms.TextBox mysqlUpdateCodeBox;
        private System.Windows.Forms.GroupBox updateGroup;
        private System.Windows.Forms.GroupBox insertGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button executeUpdateSQL;
        private System.Windows.Forms.Button executeInsertSQL;
        private System.Windows.Forms.Label updateSQLLabel;
        private System.Windows.Forms.Label insertSQLLabel;
    }
}