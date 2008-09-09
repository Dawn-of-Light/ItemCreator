namespace ItemCreator
{
    partial class editMobAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editMobAssignment));
            this.dropCountTextBox = new RegExControls.RegExTextBox();
            this.lootTemplateIdTextBox = new System.Windows.Forms.TextBox();
            this.mobNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mobxtemplateIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropCountTextBox
            // 
            this.dropCountTextBox.AccessibleDescription = null;
            this.dropCountTextBox.AccessibleName = null;
            resources.ApplyResources(this.dropCountTextBox, "dropCountTextBox");
            this.dropCountTextBox.BackgroundImage = null;
            this.dropCountTextBox.Font = null;
            this.dropCountTextBox.Name = "dropCountTextBox";
            this.dropCountTextBox.Regular_Expression = "^[0-9]*$";
            // 
            // lootTemplateIdTextBox
            // 
            this.lootTemplateIdTextBox.AccessibleDescription = null;
            this.lootTemplateIdTextBox.AccessibleName = null;
            resources.ApplyResources(this.lootTemplateIdTextBox, "lootTemplateIdTextBox");
            this.lootTemplateIdTextBox.BackgroundImage = null;
            this.lootTemplateIdTextBox.Font = null;
            this.lootTemplateIdTextBox.Name = "lootTemplateIdTextBox";
            this.lootTemplateIdTextBox.ReadOnly = true;
            // 
            // mobNameTextBox
            // 
            this.mobNameTextBox.AccessibleDescription = null;
            this.mobNameTextBox.AccessibleName = null;
            resources.ApplyResources(this.mobNameTextBox, "mobNameTextBox");
            this.mobNameTextBox.BackgroundImage = null;
            this.mobNameTextBox.Font = null;
            this.mobNameTextBox.Name = "mobNameTextBox";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Font = null;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
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
            // mobxtemplateIdTextBox
            // 
            this.mobxtemplateIdTextBox.AccessibleDescription = null;
            this.mobxtemplateIdTextBox.AccessibleName = null;
            resources.ApplyResources(this.mobxtemplateIdTextBox, "mobxtemplateIdTextBox");
            this.mobxtemplateIdTextBox.BackgroundImage = null;
            this.mobxtemplateIdTextBox.Font = null;
            this.mobxtemplateIdTextBox.Name = "mobxtemplateIdTextBox";
            this.mobxtemplateIdTextBox.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // editMobAssignment
            // 
            this.AcceptButton = this.saveButton;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.dropCountTextBox);
            this.Controls.Add(this.lootTemplateIdTextBox);
            this.Controls.Add(this.mobNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.mobxtemplateIdTextBox);
            this.Controls.Add(this.label1);
            this.Font = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editMobAssignment";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RegExControls.RegExTextBox dropCountTextBox;
        private System.Windows.Forms.TextBox lootTemplateIdTextBox;
        private System.Windows.Forms.TextBox mobNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox mobxtemplateIdTextBox;
        private System.Windows.Forms.Label label1;
    }
}