using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace ItemCreatorUpdater
{
    public partial class UpdaterMainForm : Form
    {
        private string zipfile = Application.StartupPath + Path.DirectorySeparatorChar + "ItemCreator.zip";
        private string itemcreatorExe = Application.StartupPath +  Path.DirectorySeparatorChar + "ItemCreator.exe";
        private bool checksDone = false;

        public UpdaterMainForm()
        {            
            InitializeComponent();
        }

        private bool doUnzipFile()
        {
            try
            {
                FastZip fastZip = new FastZip();
                fastZip.ExtractZip(zipfile, Application.StartupPath, "");
                statusLabel.Text = "Update done!";
                this.Update();
                checksDone = true;
                return true;
            }
            catch
            {
                statusLabel.Text = "The archive seems to be corrupt!" + System.Environment.NewLine + "Please re-download.";
                checksDone = true;
                return false;
            }
        }

        private void closeAndStartMain()
        {
            this.Update();
            System.Threading.Thread.Sleep(2000);

            //Schließen
            Application.Exit();

            //ItemCreatore Starten
            System.Diagnostics.Process.Start(itemcreatorExe);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Update();
            System.Threading.Thread.Sleep(1000);
            if (System.IO.File.Exists(zipfile))
            {
                doUnzipFile();
                closeAndStartMain();
                System.IO.File.Delete(zipfile);
            }
            else
            {
                checksDone = true;
                statusLabel.Text = "No updates found!";
                closeAndStartMain();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(checksDone == false) e.Cancel = true;
        }
    }
}