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

namespace BugTrackingSystemWithSQlite
{
    public partial class Form1 : Form
    {
        private String dbFileName;
        private SQLiteConnection dbConnect;
        private SQLiteCommand dbCommand;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnect = new SQLiteConnection();
            dbCommand = new SQLiteCommand();

            dbFileName = "BugTracking.sqlite";
            lbForlbStatus.Text = "Disconnected";
        }

        //Создание файла БД
        private void bnCreateDB_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;

                dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS ProjectList (id INTEGER PRIMARY KEY AUTOINCREMENT, Project TEXT)";
                dbCommand.ExecuteNonQuery();

                lbForlbStatus.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                lbForlbStatus.Text = "Disconnected";
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        //Подключение к файлу БД        
        private void bnConnectFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                MessageBox.Show("Необходимо создать файл базы данных");

            try
            {
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;

                lbForlbStatus.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                lbForlbStatus.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Чтение данных из БД
        private void bnReadAll_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;

            if (dbConnect.State != ConnectionState.Open)
            {
                MessageBox.Show("Установите соединение с файлом базы данных");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM Catalog";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dgvViewer.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Таблица пуста");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        //Добавление строк в БД
        private void bnAddData_Click(object sender, EventArgs e)
        {
            if (dbConnect.State != ConnectionState.Open)
            {
                MessageBox.Show("Установите соединение с файлом базы данных");
                return;
            }            
                try
                {
                    dbCommand.CommandText = "INSERT INTO ProjectList ('Project') values ('" +
                        textBox1.Text + "')";

                    dbCommand.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DataBase Files(*.db;*.sdb;*.sqlite;*.db3;*.s3db;*.sqlite3;*.sl3;)|";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            dbFileName = "Data Source=" + filename + ";" + "Version=3";
        }
    }
}
