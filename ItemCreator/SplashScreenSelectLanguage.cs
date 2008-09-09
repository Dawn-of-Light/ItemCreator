using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ItemCreator
{
    public partial class SplashScreenSelectLanguage : Form
    {
        private DataTable languages = null;
        
        public SplashScreenSelectLanguage()
        {            
            InitializeComponent();

            languages = this.getLanguageCodes();
            selectLanguageSelectBox.DataSource = languages;
            selectLanguageSelectBox.ValueMember = "language_code";
            selectLanguageSelectBox.DisplayMember = "language";
        }

        private DataTable getLanguageCodes()
        {
            DataTable dt = new DataTable();
            //Basic Table
            dt.Columns.Add("language");
            dt.Columns.Add("language_code");

            //Delimiter for whole language
            char[] lang_delimiter = { ',' };
            //Delimter splits language and language_code
            char[] language_code_delimiter = { '=' };

            string supported_languages = Properties.Settings.Default.supported_languages;
            string[] supported_languages_array = supported_languages.Split(lang_delimiter);
            foreach (string current in supported_languages_array)
            {
                dt.Rows.Add(current.Split(language_code_delimiter));
            }

            return dt;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string selected_language_code = selectLanguageSelectBox.SelectedValue.ToString();
            Properties.Settings.Default.language = selected_language_code;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }
    }
}