using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ItemCreator
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            //DEBUG - einstellung löschen
            //Properties.Settings.Default.Reset();
            //Properties.Settings.Default.Save();

            if (Properties.Settings.Default.language == "")
            {
                SplashScreenSelectLanguage form = new SplashScreenSelectLanguage();
                DialogResult dialog = form.ShowDialog();
            }
            if (Properties.Settings.Default.language == "")
            {
                Properties.Settings.Default.language = "en";
                Properties.Settings.Default.Save();
            }

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            InitializeComponent();

            statusText.Visible = true;
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.statusText.Text = "starting ...";
            this.statusProgressBar.Value = 100;
        }

        public void updateState(string statusText, int statusValue)
        {
            this.statusText.Text = statusText;
            this.statusProgressBar.Value = statusValue;
            this.Update();
            this.Focus();
        }
    }
}