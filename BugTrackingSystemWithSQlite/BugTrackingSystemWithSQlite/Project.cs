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
    class Project
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;

        public Project(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
        {
            this.dbFileName = dbFileName;
            this.dbConnect = dbConnect;
            this.dbCommand = dbCommand;
        }
        //Добавление строк в БД
        public void AddNameProject(string tbProjectName)
        {               
            if (File.Exists(dbFileName))
            {
                dbConnect = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                dbConnect.Open();
                dbCommand.Connection = dbConnect;

                try
                {
                    dbCommand.CommandText = "INSERT INTO ProjectList ('Project') values ('" +
                        tbProjectName + "')";

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
        public void DeleteNameProject()
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

        public void ShowProjects(DataGridView dgvViewer)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
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
            dgvViewer.Columns["Project"].Visible = true;
        }
    }
}
