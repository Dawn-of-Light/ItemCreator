using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ItemCreator
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            this.appNameLabel.Text = Application.ProductName;
            this.publisherLabel.Text = "Stefan Schäfer aka Merec";
            this.versionLabel.Text = Application.ProductVersion;
        }
    }
}