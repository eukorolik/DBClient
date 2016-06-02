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
             DataTable DBList = DBConnection.GetSchema("Databases");

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
            SelectTables();
        }

        protected void SelectTables()
        {
            var cmd = new MySqlCommand("SHOW TABLES", DBConnection);
            
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
        }


        private void DataSaveButton_Click(object sender, EventArgs e)
        {
            Data.Update();
        }

        private void ResultTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            throw new PoetezClientException(e.Exception.Message);
        }

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



