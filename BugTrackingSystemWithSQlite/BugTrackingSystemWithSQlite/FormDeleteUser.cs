﻿using System;
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
    public partial class FormDeleteUser : Form
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;
        public FormDeleteUser(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
        {
            InitializeComponent();
            this.dbFileName = dbFileName;
            this.dbConnect = dbConnect;
            this.dbCommand = dbCommand;
        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            string sqlQuery;
            DataTable dTable = new DataTable();
            sqlQuery = "SELECT User FROM UserList";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
            adapter.Fill(dTable);
            cbUserNameForDelete.Items.Clear();

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                cbUserNameForDelete.Items.AddRange(dTable.Rows[i].ItemArray);
            }
        }       

        
        private void bnDeleteUser_Click(object sender, EventArgs e)
        {
            string sqlQuery = "DELETE FROM UserList WHERE User = '" + cbUserNameForDelete.SelectedItem.ToString() + "'";
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
