namespace ItemCreator
{
    partial class mysql_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mysql_test));
            this.exceptionText = new System.Windows.Forms.Label();
            this.failedLabel = new System.Windows.Forms.Label();
            this.testingLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exceptionText
            // 
            this.exceptionText.Location = new System.Drawing.Point(0, 27);
            this.exceptionText.Name = "exceptionText";
            this.exceptionText.Padding = new System.Windows.Forms.Padding(5);
            this.exceptionText.Size = new System.Drawing.Size(329, 36);
            this.exceptionText.TabIndex = 1;
            // 
            // failedLabel
            // 
            this.failedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedLabel.ForeColor = System.Drawing.Color.Red;
            this.failedLabel.Location = new System.Drawing.Point(12, 9);
            this.failedLabel.Name = "failedLabel";
            this.failedLabel.Size = new System.Drawing.Size(305, 18);
            this.failedLabel.TabIndex = 2;
            this.failedLabel.Text = "Connection failed!";
            this.failedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.failedLabel.Visible = false;
            // 
            // testingLabel
            // 
            this.testingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testingLabel.ForeColor = System.Drawing.Color.Black;
            this.testingLabel.Location = new System.Drawing.Point(12, 9);
            this.testingLabel.Name = "testingLabel";
            this.testingLabel.Size = new System.Drawing.Size(305, 18);
            this.testingLabel.TabIndex = 3;
            this.testingLabel.Text = "testing ...";
            this.testingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.testingLabel.Visible = false;
            // 
            // retryButton
            // 
            this.retryButton.Location = new System.Drawing.Point(137, 66);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(40, 23);
            this.retryButton.TabIndex = 4;
            this.retryButton.Text = "retry";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // mysql_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 93);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.testingLabel);
            this.Controls.Add(this.failedLabel);
            this.Controls.Add(this.exceptionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mysql_test";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  MySQL-Connection Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label exceptionText;
        private System.Windows.Forms.Label failedLabel;
        private System.Windows.Forms.Label testingLabel;
        private System.Windows.Forms.Button retryButton;
    }
}