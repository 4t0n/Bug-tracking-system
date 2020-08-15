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
    class User
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;

        public User(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
        {
            this.dbFileName = dbFileName;
            this.dbConnect = dbConnect;
            this.dbCommand = dbCommand;
        }
        //Добавление строк в БД
        public void AddNameUsers(string tbUserName)
        {
            if (File.Exists(dbFileName))
            {
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;

                try
                {
                    dbCommand.CommandText = "INSERT INTO UserList ('User') values ('" +
                        tbUserName + "')";

                    dbCommand.ExecuteNonQuery();
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

        //Вызов формы для удаления проекта
        public void DeleteNameUsers()
        {
            if (File.Exists(dbFileName))
            {
                FormDeleteProject formDeleteProject = new FormDeleteProject(dbFileName, dbConnect, dbCommand);
                formDeleteProject.Show();
            }
            else
            {
                MessageBox.Show("Необходимо создать или открыть файл базы данных!");
            }
        }

        //Показать список пользователей
        public void ShowUsers(DataGridView dgvViewer)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            try
            {
                sqlQuery = "SELECT * FROM UserList";
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
            dgvViewer.Columns["User"].Visible = true;
        }
    }
}
