using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ItemCreator
{
    public partial class exportItem : Form
    {
        MainForm mainForm;

        private string cSharpCode = "";
        private string mysqlInsetSQL = "";
        private string mysqlUpdateSQL = "";

        public exportItem(MainForm sender)
        {
            mainForm = sender;

            InitializeComponent();
            setSQLOptions();
        }

        private void setSQLOptions()
        {            
            try
            {
                if (mainForm.checkKeywordMysql() == true && mainForm.mysqlConnection != null)
                {
                    this.insertGroup.Enabled = true;
                    this.updateGroup.Enabled = false;
                }
                else if (mainForm.checkKeywordMysql() == false && mainForm.mysqlConnection != null)
                {
                    this.insertGroup.Enabled = false;
                    this.updateGroup.Enabled = true;
                }
                else
                {
                    this.insertGroup.Enabled = false;
                    this.updateGroup.Enabled = false;
                }

                this.csharpCodeBox.Text = cSharpCode = mainForm.item.getCSharpCode(0);
                this.mysqlInsertCodeBox.Text = mysqlInsetSQL = mainForm.item.getInsertSqlCode(0, mainForm.mysqlRow, mainForm.mysqlConnection);
                this.mysqlUpdateCodeBox.Text = mysqlUpdateSQL = mainForm.item.getUpdateSqlCode(0, mainForm.mysqlRow, mainForm.mysqlConnection);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(mainForm.mysqlConnection != null) mainForm.mysqlConnection.Close();
            }
        }

        private void executeInsertSQL_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.mysqlConnection.Open();

                this.insertGroup.Enabled = false;
                //Message: running ...
                this.insertSQLLabel.Text = this.mainForm.Locales.GetString("sql_running");
                this.Update();

                MySqlCommand cmd = new MySqlCommand(mysqlInsetSQL, mainForm.mysqlConnection);
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    this.insertGroup.Enabled = true;
                    //Message: Successfull!
                    this.insertSQLLabel.Text = this.mainForm.Locales.GetString("sql_successfull");
                }
                else
                {
                    this.insertGroup.Enabled = true;
                    //Message: No rows affected!
                    this.insertSQLLabel.Text = this.mainForm.Locales.GetString("sql_no_affected_rows");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                //Message: Error!
                this.insertSQLLabel.Text = this.mainForm.Locales.GetString("sql_error");
            }
            finally
            {
                mainForm.mysqlConnection.Close();
                System.Threading.Thread.Sleep(500);
                setSQLOptions();
            }
        }

        private void executeUpdateSQL_Click(object sender, EventArgs e)
        {
            try
            {
                mainForm.mysqlConnection.Open();

                this.updateGroup.Enabled = false;

                MySqlCommand cmd = new MySqlCommand(mysqlUpdateSQL, mainForm.mysqlConnection);
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    this.updateGroup.Enabled = true;
                    //Message: Successfull!
                    this.updateSQLLabel.Text = this.mainForm.Locales.GetString("sql_successfull");
                }
                else
                {
                    this.updateGroup.Enabled = true;
                    //Message: No rows affected!
                    this.updateSQLLabel.Text = this.mainForm.Locales.GetString("sql_no_affected_rows");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                //Message: Error!
                this.updateSQLLabel.Text = this.mainForm.Locales.GetString("sql_error");
            }
            finally
            {
                mainForm.mysqlConnection.Close();
                setSQLOptions();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            setSQLOptions();
        }
    }
}