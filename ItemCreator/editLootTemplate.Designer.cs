namespace ItemCreator
{
    partial class editLootTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editLootTemplate));
            this.lootTemplateIDTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.selectRealm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chanceTextBox = new RegExControls.RegExTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemTemplateIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.templateNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lootTemplateIDTextbox
            // 
            this.lootTemplateIDTextbox.AccessibleDescription = null;
            this.lootTemplateIDTextbox.AccessibleName = null;
            resources.ApplyResources(this.lootTemplateIDTextbox, "lootTemplateIDTextbox");
            this.lootTemplateIDTextbox.BackgroundImage = null;
            this.lootTemplateIDTextbox.Font = null;
            this.lootTemplateIDTextbox.Name = "lootTemplateIDTextbox";
            this.lootTemplateIDTextbox.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Font = null;
            this.label6.Name = "label6";
            // 
            // selectRealm
            // 
            this.selectRealm.AccessibleDescription = null;
            this.selectRealm.AccessibleName = null;
            resources.ApplyResources(this.selectRealm, "selectRealm");
            this.selectRealm.BackgroundImage = null;
            this.selectRealm.Font = null;
            this.selectRealm.FormattingEnabled = true;
            this.selectRealm.Name = "selectRealm";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Font = null;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
            // 
            // chanceTextBox
            // 
            this.chanceTextBox.AccessibleDescription = null;
            this.chanceTextBox.AccessibleName = null;
            resources.ApplyResources(this.chanceTextBox, "chanceTextBox");
            this.chanceTextBox.BackgroundImage = null;
            this.chanceTextBox.Font = null;
            this.chanceTextBox.Name = "chanceTextBox";
            this.chanceTextBox.Regular_Expression = "^[0-9]*$";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // itemTemplateIdTextBox
            // 
            this.itemTemplateIdTextBox.AccessibleDescription = null;
            this.itemTemplateIdTextBox.AccessibleName = null;
            resources.ApplyResources(this.itemTemplateIdTextBox, "itemTemplateIdTextBox");
            this.itemTemplateIdTextBox.BackgroundImage = null;
            this.itemTemplateIdTextBox.Font = null;
            this.itemTemplateIdTextBox.Name = "itemTemplateIdTextBox";
            this.itemTemplateIdTextBox.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // templateNameTextBox
            // 
            this.templateNameTextBox.AccessibleDescription = null;
            this.templateNameTextBox.AccessibleName = null;
            resources.ApplyResources(this.templateNameTextBox, "templateNameTextBox");
            this.templateNameTextBox.BackgroundImage = null;
            this.templateNameTextBox.Font = null;
            this.templateNameTextBox.Name = "templateNameTextBox";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // saveButton
            // 
            this.saveButton.AccessibleDescription = null;
            this.saveButton.AccessibleName = null;
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.BackgroundImage = null;
            this.saveButton.Font = null;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleDescription = null;
            this.cancelButton.AccessibleName = null;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.BackgroundImage = null;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = null;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // editLootTemplate
            // 
            this.AcceptButton = this.saveButton;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.lootTemplateIDTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectRealm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chanceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemTemplateIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.templateNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editLootTemplate";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lootTemplateIDTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectRealm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RegExControls.RegExTextBox chanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemTemplateIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox templateNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;

    }
}