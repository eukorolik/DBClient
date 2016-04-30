using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PoetezClient
{
    public partial class PoetezClient : Form
    {
        MySqlConnection DBConnection;
       // FieldInfo[] Fields;
        UpdateData Data;
        QueryWindow QueryWindow;

        public PoetezClient()
        {
            InitializeComponent();

            try
            {
                DBConnection = new MySqlConnection("server=127.0.0.1; uid=root; pwd=22018;");
                DBConnection.Open();
                ReadDBList();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        ~PoetezClient()
        {
            DBConnection.Close();
        }
        
        protected void ReadDBList()
        {
             var DBList = DBConnection.GetSchema("Databases");

             var DBSelectSourse = new Dictionary<string, string>();
                         
             foreach (DataRow row in DBList.Rows)
             {
                 DBSelectSourse.Add((string)row["database_name"], (string)row["database_name"]);
             }

             DBSelect.DataSource = new BindingSource(DBSelectSourse, null);
             DBSelect.DisplayMember = "Value";
             DBSelect.ValueMember = "Key";
        }
        

        private void DBSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DBName = ((KeyValuePair<string, string>)DBSelect.SelectedItem).Key;
            var cmd = new MySqlCommand("USE " + DBName, DBConnection);
            cmd.ExecuteNonQuery();
            SelectTables(cmd);
        }

        protected void SelectTables(MySqlCommand cmd)
        {
            cmd.CommandText = "SHOW TABLES";

            var DBTableSelectSourse = new Dictionary<string, string>();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DBTableSelectSourse.Add((string)reader.GetValue(0), (string)reader.GetValue(0));
                }
            }

            DBTableSelect.DataSource = new BindingSource(DBTableSelectSourse, null);
            DBTableSelect.DisplayMember = "Value";
            DBTableSelect.ValueMember = "Key";
        }

        private void DBTableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TableName = ((KeyValuePair<string, string>)DBTableSelect.SelectedItem).Key; 
            var cmd = new MySqlCommand("SELECT * FROM " + TableName, DBConnection);

            {
                Data = new UpdateData(cmd);
                ResultTable.DataSource = new BindingSource(Data.Table, null);
            }

         /*   using (var reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
            {
                var schema = reader.GetSchemaTable();

                var fields = new List<FieldInfo>();

                foreach (DataRow row in schema.Rows)
                {
                    fields.Add(new FieldInfo((bool)row["AllowDBNull"], (bool)row["IsAutoIncrement"]));
                }

                Fields = fields.ToArray();
            } */
        }

        private void DataSaveButton_Click(object sender, EventArgs e)
        {
            Data.Update();
        }

        private void ResultTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            throw new PoetezClientException(e.Exception.Message);
        }

        private void Focus(DataGridViewCell cell)
        {
            ResultTable.CurrentCell = cell;
            ResultTable.BeginEdit(true);
        }

       /* struct FieldInfo
        {
            public bool IsNullable { private set;  get; }
            public bool IsAutoIncrement { private set; get; }

            public FieldInfo(bool isNullable, bool isAutoIncrement)
            {
                IsNullable = isNullable;
                IsAutoIncrement = isAutoIncrement;
            }

            public bool IsValueNull(object value, Type type)
            {
                if (IsAutoIncrement)
                {
                    return false;
                }

                return !IsNullable && type != typeof(bool) && (value == null
                    || value == DBNull.Value
                    || string.IsNullOrEmpty(value.ToString()));
            }
        } */

        private void SQLBtn_Click(object sender, EventArgs e)
        {
            QueryWindow = new QueryWindow(DBConnection);
            QueryWindow.Show();
        }
    }

    public struct UpdateData
    {
        public MySqlDataAdapter Adapter { private set; get; }
        public DataTable Table { private set;  get; }

        public UpdateData(MySqlCommand cmd)  : this()
        {
            Adapter = new MySqlDataAdapter(cmd);
            var builder = new MySqlCommandBuilder(Adapter);
            Table = new DataTable();
            Adapter.Fill(Table);
        }

        public void Update()
        {
            Adapter.Update(Table);
        }
    }
}



