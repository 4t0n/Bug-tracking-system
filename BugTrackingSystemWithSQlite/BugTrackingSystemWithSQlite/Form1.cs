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
    public partial class Form1 : Form
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection();
            dbCommand = new SQLiteCommand();            
        }        
        
        //Добавление строк в БД
        private void bnAddNameProject_Click(object sender, EventArgs e)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();


            if (File.Exists(dbFileName))
            {
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;

                try
                {
                    dbCommand.CommandText = "INSERT INTO ProjectList ('Project') values ('" +
                        tbProjectName.Text + "')";

                    dbCommand.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

                try
                {
                    sqlQuery = "SELECT * FROM ProjectList";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                    adapter.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        dgvViewer.Rows.Clear();

                        for (int i = 0; i < dTable.Rows.Count; i++)
                            dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
                    }
                    else
                        MessageBox.Show("Данные отсутствуют");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                //dbConnect.Close();
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Создание файла
        private void toolSpFileCreate_Click(object sender, EventArgs e)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog1.Filter = "DataBase Files(*.db;*.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;)|*.db*;.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.DefaultExt = "db";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {                    
                    myStream.Close();
                    dbFileName = saveFileDialog1.FileName;
                    try
                    {
                        dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                        dbConnect.Open();
                        dbCommand.Connection = dbConnect;

                        dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS ProjectList (id INTEGER PRIMARY KEY AUTOINCREMENT, Project TEXT)";
                        dbCommand.ExecuteNonQuery();                        
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
            try
            {
                sqlQuery = "SELECT * FROM ProjectList";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);
                dgvViewer.Rows.Clear();
                for (int i = 0; i < dTable.Rows.Count; i++)
                    dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            dbConnect.Close();
        }

        //Открыть файл
        private void toolSpFileOpen_Click(object sender, EventArgs e)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "DataBase Files(*.db;*.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;)|*.db*;.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;";            
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dbFileName = openFileDialog.FileName;
                try
                {
                    dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                    dbConnect.Open();
                    dbCommand.Connection = dbConnect;

                    dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS ProjectList (id INTEGER PRIMARY KEY AUTOINCREMENT, Project TEXT)";
                    dbCommand.ExecuteNonQuery();
                    
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            try
            {
                sqlQuery = "SELECT * FROM ProjectList";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);                
                dgvViewer.Rows.Clear();
                for (int i = 0; i < dTable.Rows.Count; i++)
                    dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);                
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            //dbConnect.Close();
        }

        //Удалить проект
        private void bnDeleteProject_Click(object sender, EventArgs e)
        {
            /*string sqlQuery;
            DataTable dTable = new DataTable();

            dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            dbConnect.Open();
            dbCommand.Connection = dbConnect;
            

            try
            {
                dbCommand.CommandText = "DELETE FROM ProjectList WHERE id = 1";

                dbCommand.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            try
            {
                sqlQuery = "SELECT * FROM ProjectList";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);
                dgvViewer.Rows.Clear();
                for (int i = 0; i < dTable.Rows.Count; i++)
                    dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }*/

            FormDeleteProject formDeleteProject = new FormDeleteProject();
            formDeleteProject.Show();
        }
    }    
}
