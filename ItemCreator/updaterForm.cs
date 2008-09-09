using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ItemCreator.database;
using System.Net;
using System.IO;

namespace ItemCreator
{
    public partial class updaterForm : Form
    {
        private const string onlineDataURL = "http://dol.oecken.net/ItemCreator/update/";
        private const string onlineVersionURL = onlineDataURL + "versions.xml";

        public bool restartApp = false;
        public bool startUpdater = false;

        private MainForm mainForm;

        public updaterForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.checkVersions();
        }

        #region check versions

        public void checkVersions()
        {
            this.getLocalVersions();
            this.getOnlineVersions();
        }

        private void getLocalVersions()
        {
            this.versions.Clear();
            //versionsdatei erstellen mit aktuell installierten versionen

            //row base.xml
            ApplicationVersions.DatabaseRow baseXMLRow = this.versions.Database.NewDatabaseRow();
            baseXMLRow.filename = "database/base.xml";

            string baseFile = Application.StartupPath + "//" + baseXMLRow.filename;
            if (System.IO.File.Exists(baseFile) != false)
            {
                //Test
                BaseXMLData baseXML = new BaseXMLData();
                baseXML.version.ReadXml(baseFile);
                if (baseXML.version.Count > 0)
                {
                    baseXMLRow.local_version = (string)baseXML.version.Rows[0]["version"];
                    baseXMLRow.update = (bool)baseXML.version.Rows[0]["doUpdate"];
                }
                //Message: error reading version
                else baseXMLRow.local_version = "error reading version";
            }
            //Message: file not found
            else baseXMLRow.local_version = "file not found";
            //Message: unknown
            baseXMLRow.online_version = "unknown";
            this.versions.Database.AddDatabaseRow(baseXMLRow);

            //row models.xml
            ApplicationVersions.DatabaseRow modelsRow = this.versions.Database.NewDatabaseRow();
            modelsRow.filename = "database/models.xml";

            string modelsFile = Application.StartupPath + "//" + modelsRow.filename;
            if (System.IO.File.Exists(modelsFile) != false)
            {
                ItemModels itemModels = new ItemModels();
                itemModels.version.ReadXml(modelsFile);
                if (itemModels.version.Count > 0)
                {
                    modelsRow.local_version = (string)itemModels.version.Rows[0]["version"];
                    modelsRow.update = (bool)itemModels.version.Rows[0]["doUpdate"];
                }
                //Message: error reading version
                else modelsRow.local_version = "error reading version";
            }
            //Message: file not found
            else modelsRow.local_version = "file not found";
            //Message: unknown
            modelsRow.online_version = "unknown";
            this.versions.Database.AddDatabaseRow(modelsRow);

            //Application
            ApplicationVersions.ApplicationRow appRow = versions.Application.NewApplicationRow();
            appRow.local_version = Application.ProductVersion;
            appRow.online_version = "unknown";
            this.versions.Application.AddApplicationRow(appRow);

            this.versions.WriteXml(Application.StartupPath + "//versions.xml");
        }

        private void getOnlineVersions()
        {
            try
            {
                ApplicationVersions onlineVersions = new ApplicationVersions();
                onlineVersions.ReadXml(onlineVersionURL);

                //Local Version of Application
                Version localapp = new Version(Application.ProductVersion);
                Version onlineApp = new Version();
                if (onlineVersions.Application.Count > 0)
                {
                    //Online Version of Application
                    onlineApp = new Version(onlineVersions.Application.Rows[0]["local_version"].ToString());

                    this.versions.Application.Rows[0]["online_version"] = (string)onlineVersions.Application.Rows[0]["local_version"];
                }
                else this.versions.Application.Rows[0]["online_version"] = "0";

                //Compare online and local version
                if (onlineApp > localapp) this.applicationUpdatesAvailable = true;

                foreach (ApplicationVersions.DatabaseRow row in this.versions.Database.Rows)
                {
                    ApplicationVersions.DatabaseRow onlineRow = (ApplicationVersions.DatabaseRow)onlineVersions.Database.FindByfilename(row.filename);
                    if (onlineRow != null)
                    {
                        row.online_version = (string)onlineRow.local_version;

                        //local version of database
                        Version local = new Version(row.local_version);
                        //online version of database
                        Version online = new Version(row.online_version);

                        //Compare local and online version
                        if (local < online && row.update == true)
                        {
                            row.update = true;
                            //one database needs an update
                            this.databaseUpdatesAvailable = true;
                        }
                        else row.update = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private bool applicationUpdatesAvailable = false;
        private bool databaseUpdatesAvailable = false;
        public bool IsNewApplicationVersionAvailable()
        {
            return applicationUpdatesAvailable;
        }

        public bool IsNewDatabaseUpdateAvailable()
        {
            return databaseUpdatesAvailable;
        }

        private void checkDatabaseButton_Click(object sender, EventArgs e)
        {
            //Message: checking versions ... 
            checkVersionLabel.Text = mainForm.Locales.GetString("updater_checking_version");
            this.Update();

            this.getOnlineVersions();

            //Message: check done!
            checkVersionLabel.Text = mainForm.Locales.GetString("updater_check_done");
            this.Update();
        }

        private byte[] ReadStream(Stream receiveStream, ProgressBar progressBar)
        {
            byte[] buffer = new byte[4096]; // size of the buffer can be adjusted for speed optimization

            using (MemoryStream ms = new MemoryStream())
            {
                while (true)
                {
                    int count = receiveStream.Read(buffer, 0, buffer.Length);

                    if (count <= 0) return ms.ToArray();

                    ms.Write(buffer, 0, count);
                    // update read status here
                    // unless you are doing multiple threads with invokes
                    // you will also want to do an Application.DoEvents()
                    // or nothing will appear to be updated
                    progressBar.Value = Convert.ToInt32(ms.Length / 2048);
                    Application.DoEvents();
                }
            }
        }

        private void updateDatabaseFiles()
        {
            updateDatabases.Enabled = false;
            foreach (ApplicationVersions.DatabaseRow row in this.versions.Database.Rows)
            {
                if (row.update == true)
                {
                    try
                    {
                        string online_filename = onlineDataURL + row.filename;
                        string local_filename = Application.StartupPath + "//" + row.filename;

                        //Message: Downloading FILENAME ...
                        string message = String.Format(mainForm.Locales.GetString("updater_downloading_file"), row.filename);
                        downloadDatabaseLabel.Text = message;
                        downloadDatabaseProgressBar.Visible = true;

                        // Creates an HttpWebRequest with the specified URL. 
                        HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(online_filename);
                        // Sends the HttpWebRequest and waits for the response.            
                        HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                        // Gets the stream associated with the response.
                        Stream receiveStream = myHttpWebResponse.GetResponseStream();

                        downloadDatabaseProgressBar.Maximum = Convert.ToInt32(myHttpWebResponse.ContentLength / 2048);

                        byte[] data = ReadStream(receiveStream, downloadDatabaseProgressBar);
                        FileStream fs = File.Create(local_filename);
                        fs.Write(data, 0, data.Length);
                        fs.Close();
                        receiveStream.Close();
                        //Message: ItemCreator need to be restarted!
                        restartLabel.Text = mainForm.Locales.GetString("updater_restart_app");
                        restartApp = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            //Message: Update complete!
            downloadDatabaseLabel.Text = mainForm.Locales.GetString("updater_update_complete");
            downloadDatabaseProgressBar.Visible = false;
            
            //getFileVersions();
            //checkDatabaseButton_Click(null, null);

            updateDatabases.Enabled = true;
        }

        private void updateDatabases_Click(object sender, EventArgs e)
        {
            updateDatabaseFiles();
        }

        private void updateApplicationFiles(object sender, EventArgs e)
        {
            updateApplicationButton.Enabled = false;
            try
            {
                string online_filename = onlineDataURL + "ItemCreator.zip";
                string local_filename = Application.StartupPath + "//" + "ItemCreator.zip";

                //Message: Downloading ItemCreator-Files ...
                downloadApllicationLabel.Text = mainForm.Locales.GetString("updater_downloading_files");
                downloadApplicationProgressBar.Visible = true;

                // Creates an HttpWebRequest with the specified URL. 
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(online_filename);
                // Sends the HttpWebRequest and waits for the response.            
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                // Gets the stream associated with the response.
                Stream receiveStream = myHttpWebResponse.GetResponseStream();

                downloadApplicationProgressBar.Maximum = Convert.ToInt32(myHttpWebResponse.ContentLength / 2048);

                byte[] data = ReadStream(receiveStream, downloadApplicationProgressBar);
                FileStream fs = File.Create(local_filename);
                fs.Write(data, 0, data.Length);
                fs.Close();
                receiveStream.Close();

                //Message: ItemCreator need to be restarted!
                restartLabel.Text = mainForm.Locales.GetString("updater_need_start");
                startUpdater = true;

                //Message: Update complete!
                downloadApllicationLabel.Text = mainForm.Locales.GetString("updater_update_complete");
                downloadApplicationProgressBar.Visible = false;
            }
            catch (Exception ex)
            {
                //Message: Error!
                downloadApllicationLabel.Text = mainForm.Locales.GetString("updater_error");
                MessageBox.Show(ex.Message);
            }
            updateDatabases.Enabled = true;
        }
    }
}