using MySql.Data.MySqlClient;

namespace ItemCreator.database {

    partial class ItemTemplates
    {
        partial class ItemTemplateDataTable
        {
        }
        /// <summary>
        /// Sets not asked values to its reference
        /// </summary>
        /// <param name="row">row of the Item</param>
        public void setDefaultItemValues(int row)
        {
            ItemTemplates.ItemTemplateRow tempRow = (ItemTemplates.ItemTemplateRow)this.ItemTemplate.Rows[row];

            if (!tempRow.IsMaxChargesNull()) tempRow.Charges = tempRow.MaxCharges;
            if (!tempRow.IsMaxCharges1Null()) tempRow.Charges1 = tempRow.MaxCharges1;
            if (!tempRow.IsPoisonChargesNull()) tempRow.PoisonCharges = tempRow.PoisonMaxCharges;
        }

        /// <summary>
        /// Load an Item to the Table
        /// </summary>
        /// <param name="connection">MySqlConnection</param>
        /// <param name="itemKeyname">Id_nb of the Item</param>
        /// <param name="databaseName">database name</param>
        public void loadFromDatabase(MySqlConnection connection, string itemKeyname, string databaseName)
        {
            System.Data.DataSet ds = new System.Data.DataSet();

            try
            {
                connection.Open();

                //Nicht alle Datenbanken entsprechen dem Template, also alle Spalten
                //aus der Datenbank ziehen und vergleichen.
                System.Data.DataTable columnsTable = new System.Data.DataTable();
                string datacolumnSQL = "SHOW COLUMNS FROM " + databaseName;
                MySqlCommand datacolumncmd = new MySqlCommand(datacolumnSQL, connection);
                MySqlDataReader reader = datacolumncmd.ExecuteReader();
                while (reader.Read())
                {
                    columnsTable.Columns.Add(reader.GetString(0));
                }
                reader.Close();

                string columnsSQL = "";
                foreach (System.Data.DataColumn column in columnsTable.Columns)
                {
                    if (this.ItemTemplate.Columns.Contains(column.ColumnName))
                    {
                        if (columnsSQL != "") columnsSQL += ", ";
                        columnsSQL += "`" + column.ColumnName + "`";
                    }
                }
                string SQL = "SELECT " + columnsSQL + " FROM " + databaseName + " WHERE Id_nb = '" + itemKeyname + "' LIMIT 0,1";
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = SQL;
                cmd.Connection = connection;

                adapter.SelectCommand = cmd;
                this.ItemTemplate.Clear();
                adapter.Fill(this.ItemTemplate);
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "");
            }
            finally
            {
                connection.Close();
            }

            //return row;
        }
        
        /// <summary>
        /// Loads an Item from Database
        /// </summary>
        /// <param name="connection">MySqlConnection</param>
        /// <param name="itemKeyname">Id_nb of the Item</param>
        /// <param name="databaseName">The name of the Database</param>
        /// <returns></returns>
        public ItemTemplates.ItemTemplateRow loadRowFromDatabase(MySqlConnection connection, string itemKeyname, string databaseName)
        {
            try
            {
                connection.Open();

                string columnsSQL = "";
                for (int i = 0; i < this.ItemTemplate.Columns.Count; i++)
                {
                    if (i != 0) columnsSQL += ", ";

                    columnsSQL += "`" + this.ItemTemplate.Columns[i].ColumnName + "`";
                }
                string SQL = "SELECT " + columnsSQL + " FROM " + databaseName + " WHERE Id_nb = '" + itemKeyname + "' LIMIT 0,1";

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = SQL;
                cmd.Connection = connection;

                adapter.SelectCommand = cmd;

                ItemTemplates tmp = new ItemTemplates();
                adapter.Fill(tmp.ItemTemplate);

                return (ItemTemplates.ItemTemplateRow)tmp.ItemTemplate.Rows[0];
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return this.ItemTemplate.NewItemTemplateRow();
        }

        /// <summary>
        /// Return the CSharp Code of the representative row
        /// </summary>
        /// <param name="row">id of the row</param>
        /// <returns>string code</returns>
        public string getCSharpCode(int row)
        {
            setDefaultItemValues(row);
            ItemTemplates.ItemTemplateRow tempRow = (ItemTemplates.ItemTemplateRow)this.ItemTemplate.Rows[row];

            string code = "";

            code += "ItemTemplate " + tempRow.Id_nb + " = null;" + System.Environment.NewLine;
            code += tempRow.Id_nb + " = (ItemTemplate) GameServer.Database.FindObjectByKey(typeof (ItemTemplate), \"" + tempRow.Id_nb + "\");" + System.Environment.NewLine;
            code += "if (" + tempRow.Id_nb + " == null)" + System.Environment.NewLine;
            code += "{" + System.Environment.NewLine;
            code += "    if (log.IsWarnEnabled) log.Warn(\"Could not find " + tempRow.Id_nb + ", creating it ...\");" + System.Environment.NewLine;

            for (int i = 0; i < this.ItemTemplate.Columns.Count; i++)
            {
                object value = tempRow[this.ItemTemplate.Columns[i].ColumnName];

                if (value.GetType() != System.DBNull.Value.GetType() && this.ItemTemplate.Columns[i].ColumnName != "ItemTemplate_ID")
                {
                    switch (value.GetType().ToString())
                    {
                        case "System.String":
                            {
                                if ((string)value != "") code += "    " + tempRow.Id_nb + "." + this.ItemTemplate.Columns[i].ColumnName + " = \"" + value.ToString() + "\";" + System.Environment.NewLine;
                                break;
                            }
                        case "System.Boolean":
                            {
                                code += "    " + tempRow.Id_nb + "." + this.ItemTemplate.Columns[i].ColumnName + " = " + value.ToString().ToLower() + ";" + System.Environment.NewLine;
                                break;
                            }
                        default:
                            {
                                if (System.Convert.ToInt32(value) != 0) code += "    " + tempRow.Id_nb + "." + this.ItemTemplate.Columns[i].ColumnName + " = " + value.ToString() + ";" + System.Environment.NewLine;
                                break;
                            }
                    }
                }
            }

            code += "    if (SAVE_INTO_DATABASE) GameServer.Database.AddNewObject(" + tempRow.Id_nb + ");" + System.Environment.NewLine;
            code += "}";

            return code;
        }

        private string escapeString(string value)
        {
            value = value.Replace("\\", "\\\\");
            value = value.Replace("'", "\\'");

            return value;
        }

        public string getInsertSqlCode(int row, database.Preferences.MySQLRow mysqlRow, MySqlConnection connection)
        {
            setDefaultItemValues(row);
            ItemTemplates.ItemTemplateRow tempRow = (ItemTemplates.ItemTemplateRow)this.ItemTemplate.Rows[row];
            System.Data.DataTable columnsTable = new System.Data.DataTable();

            //automatic detection
            if (mysqlRow.cellDetection == true && connection != null)
            {
                try
                {
                    connection.Open();
                    string SQL = "SHOW COLUMNS FROM " + mysqlRow.ItemTemplateTable;

                    MySqlCommand cmd = new MySqlCommand(SQL, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        columnsTable.Columns.Add(reader.GetString(0));
                    }
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    columnsTable = this.ItemTemplate;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                columnsTable = this.ItemTemplate.Clone();

                if (mysqlRow.ArtiID == false) columnsTable.Columns.Remove("ArtiID");
            }

            string columnsSQL = "";
            string dataSQL = "";
            bool insertedColumn = false;
            bool insertedData = false;
            foreach (System.Data.DataColumn column in columnsTable.Columns)
            {
                if (this.ItemTemplate.Columns.Contains(column.ColumnName))
                {
                    if(!tempRow.IsNull(column.ColumnName)) 
                    {
                        object value = tempRow[column.ColumnName];

                        switch (value.GetType().ToString())
                        {
                            case "System.String":
                                {
                                    if ((string)value != "")
                                    {
                                        if (insertedColumn == false)
                                        {
                                            columnsSQL += "`" + column.ColumnName + "`";
                                            insertedColumn = true;
                                        }
                                        else columnsSQL += ", `" + column.ColumnName + "`";

                                        if (insertedData != false) dataSQL += ", ";
                                        else insertedData = true;
                                        dataSQL += "'" + this.escapeString(value.ToString()) + "'";
                                    }
                                    break;
                                }
                            case "System.Boolean":
                                {
                                    if (insertedColumn == false)
                                    {
                                        columnsSQL += "`" + column.ColumnName + "`";
                                        insertedColumn = true;
                                    }
                                    else columnsSQL += ", `" + column.ColumnName + "`";

                                    if (insertedData != false) dataSQL += ", ";
                                    else insertedData = true;

                                    if ((bool)value == true) dataSQL += "1";
                                    else dataSQL += "0";
                                    break;
                                }
                            default:
                                {
                                    if (System.Convert.ToInt32(value) != 0)
                                    {
                                        if (insertedColumn == false)
                                        {
                                            columnsSQL += "`" + column.ColumnName + "`";
                                            insertedColumn = true;
                                        }
                                        else columnsSQL += ", `" + column.ColumnName + "`";

                                        if (insertedData != false) dataSQL += ", ";
                                        else insertedData = true;
                                        dataSQL += value.ToString();
                                    }
                                    break;
                                }
                        }
                    }
                }
            }

            string code;
            code = "REPLACE INTO " + mysqlRow.ItemTemplateTable + " (" + columnsSQL + ") VALUES (" + dataSQL + ")";

            return code;
        }

        public string getUpdateSqlCode(int row, database.Preferences.MySQLRow mysqlRow, MySqlConnection connection)
        {
            setDefaultItemValues(row);
            ItemTemplates.ItemTemplateRow tempRow = (ItemTemplates.ItemTemplateRow)this.ItemTemplate.Rows[row];
            System.Data.DataTable columnsTable = new System.Data.DataTable();

            //automatic detection
            if (mysqlRow.cellDetection == true && connection != null)
            {
                try
                {
                    connection.Open();
                    string SQL = "SHOW COLUMNS FROM " + mysqlRow.ItemTemplateTable;

                    MySqlCommand cmd = new MySqlCommand(SQL, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        columnsTable.Columns.Add(reader.GetString(0));
                    }
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    columnsTable = this.ItemTemplate;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {                
                columnsTable = this.ItemTemplate.Clone();

                if (mysqlRow.ArtiID == false) columnsTable.Columns.Remove("ArtiID");
            }

            string dataSQL = "";
            bool insertedData = false;

            string sqlCodeRaw = "";
            int i = 0;
            foreach (System.Data.DataColumn column in columnsTable.Columns)
            {
                if (this.ItemTemplate.Columns.Contains(column.ColumnName))
                {
                    if (sqlCodeRaw != "") sqlCodeRaw += ", ";
                    sqlCodeRaw += "`" + column.ColumnName + "` = @value"+i;
                }
                i++;
            }
            string sqlCode = "UPDATE " + mysqlRow.ItemTemplateTable + " SET " + sqlCodeRaw;

            MySqlCommand c = new MySqlCommand(sqlCode);
            i = 0;
            foreach (System.Data.DataColumn column in columnsTable.Columns)
            {
                if (this.ItemTemplate.Columns.Contains(column.ColumnName))
                {
                    object value = tempRow[column.ColumnName];
                    c.Parameters.AddWithValue("value" + i, value);
                }
                i++;
            }
            
            foreach (System.Data.DataColumn column in columnsTable.Columns)
            {
                if (this.ItemTemplate.Columns.Contains(column.ColumnName))
                {
                    if (column.Unique == false && column.ColumnName != "ItemTemplate_ID")
                    {
                        if (tempRow.IsNull(column.ColumnName))
                        {
                            if (insertedData != false) dataSQL += ", ";
                            else insertedData = true;
                            dataSQL += "`" + column.ColumnName + "` = NULL";
                            break;
                        }
                        else {

                            object value = tempRow[column.ColumnName];
                        //if (value.GetType() != System.DBNull.Value.GetType())
                        //{
                            //Alle Spalten die einen Wert enthalten werdne in der SQL aufgelistet, um NULL-Werte automatisch setzen zu können
                            //columnsSQL

                            switch (value.GetType().ToString())
                            {
                                case "System.String":
                                    {
                                        if (insertedData != false) dataSQL += ", ";
                                        else insertedData = true;
                                        dataSQL += "`" + column.ColumnName + "` = '" + this.escapeString(value.ToString()) + "'";
                                        break;
                                    }
                                case "System.Boolean":
                                    {
                                        if (insertedData != false) dataSQL += ", ";
                                        else insertedData = true;

                                        if ((bool)value == true) dataSQL += "`" + column.ColumnName + "` = 1";
                                        else dataSQL += "`" + column.ColumnName + "` = 0";
                                        break;
                                    }
                                case "System.DBNull":
                                    {
                                        if (insertedData != false) dataSQL += ", ";
                                        else insertedData = true;
                                        dataSQL += "`" + column.ColumnName + "` = NULL";
                                        break;
                                    }
                                default:
                                    {
                                        if (insertedData != false) dataSQL += ", ";
                                        else insertedData = true;
                                        dataSQL += "`" + column.ColumnName + "` = " + value.ToString();
                                        break;
                                    }
                            }
                        }
                    }
                }
            }

            string code;
            code = "UPDATE " + mysqlRow.ItemTemplateTable + " SET " + dataSQL + " WHERE `Id_nb` = '" + tempRow.Id_nb + "' LIMIT 1";
            
            
            return code;
        }
    }
}
