using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTrackingSystemWithSQlite
{
    public partial class FormDeleteProject : Form
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;
        public FormDeleteProject(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
        {
            InitializeComponent();
            this.dbFileName = dbFileName;
            this.dbConnect = dbConnect;
            this.dbCommand = dbCommand;
        }        

        private void FormDeleteProject_Load_1(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT Project FROM ProjectList";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            cbProjectNameForDelete.Items.Clear();

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                cbProjectNameForDelete.Items.AddRange(dTable.Rows[i].ItemArray);
            }
        }

        private void bnDeleteProject_Click(object sender, EventArgs e)
        {
            string sqlQuery = "DELETE FROM ProjectList WHERE Project = '"+cbProjectNameForDelete.SelectedItem.ToString()+"'";
            try
            {
                dbCommand.CommandText = sqlQuery;                
                dbCommand.ExecuteNonQuery();
                MessageBox.Show("Проект удалён.");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }            
            this.Close();
        }
    }
}
