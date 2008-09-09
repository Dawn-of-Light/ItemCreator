namespace ItemCreator
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.statusText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(0, 150);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(300, 15);
            this.statusProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.statusProgressBar.TabIndex = 0;
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.Transparent;
            this.statusText.Location = new System.Drawing.Point(108, 9);
            this.statusText.Name = "statusText";
            this.statusText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusText.Size = new System.Drawing.Size(180, 13);
            this.statusText.TabIndex = 1;
            this.statusText.Text = "status";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusText.Visible = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(300, 165);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.statusProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemCreator loading....";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashScreen_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar statusProgressBar;
        public System.Windows.Forms.Label statusText;

    }
}