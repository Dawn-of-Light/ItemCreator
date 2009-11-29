using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ItemCreator.database;

namespace ItemCreator
{
    public partial class mysql_test : Form
    {
        private Preferences.MySQLRow mysqlRow;
        private string mysqlException;

        private MySqlConnection _mysqlConnection = null;
        public MySqlConnection mysqlConnection
        {
            get { return this._mysqlConnection; }
            set { this._mysqlConnection = value; }
        }

        public mysql_test(Preferences.MySQLRow mysqlRow)
        {
            this.mysqlRow = mysqlRow;

            bool testCheck = testConnection();
            if (testCheck == false)
            {
                InitializeComponent();

                this.testingLabel.Visible = false;
                this.failedLabel.Visible = true;
                this.exceptionText.Text = this.mysqlException;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void testing()
        {
            this.testingLabel.Visible = true;
            this.failedLabel.Visible = false;
            this.exceptionText.Text = "";
            this.Update();
            System.Threading.Thread.Sleep(100);
            
            bool testCheck = testConnection();
            if (testCheck == false)
            {
                this.testingLabel.Visible = false;
                this.failedLabel.Visible = true;
                this.exceptionText.Text = this.mysqlException;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool testConnection()
        {
            bool returning;
            
            //Teste Mysql-Verbindung
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = mysqlRow.Host;
            connectionString.Port = mysqlRow.Port;
            connectionString.Database = mysqlRow.Database;
            connectionString.UserID = mysqlRow.UserID;
            connectionString.Password = mysqlRow.Password;
            connectionString.ConnectionTimeout = 3;

            MySqlConnection connection = new MySqlConnection(connectionString.ConnectionString);

            try
            {
                connection.Open();
                this.mysqlConnection = connection;
                returning = true;
            }
            catch (MySqlException ex)
            {
                this.mysqlException = ex.Message;
                returning = false;
            }
            finally
            {
                connection.Close();
            }

            return returning;
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            this.testing();
        }
    }
}