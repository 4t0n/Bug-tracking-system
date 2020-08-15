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
    class Task
    {
        public string dbFileName;
        public SQLiteConnection dbConnect;
        public SQLiteCommand dbCommand;

        public Task(string dbFileName, SQLiteConnection dbConnect, SQLiteCommand dbCommand)
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

        //Показать список проектов
        public void ShowTasks(DataGridView dgvViewer)
        {
            string sqlQuery;
            DataTable dTable = new DataTable();
            DataGridViewTextBoxColumn dgvIdTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTask = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvProject = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvTheme = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvPriority = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvUser = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dgvDescription = new DataGridViewTextBoxColumn();
            try
            {
                sqlQuery = "SELECT * FROM TaskList";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbConnect);
                adapter.Fill(dTable);
                dgvViewer.Rows.Clear();                
                dgvViewer.Columns.Clear();
                dgvIdTask.Name = "idTask";
                dgvIdTask.HeaderText = "Порядковый номер";
                dgvTask.Name = "Task";
                dgvTask.HeaderText = "Название задачи";
                dgvProject.Name = "Project";
                dgvProject.HeaderText = "Проект";
                dgvTheme.Name = "Theme";
                dgvTheme.HeaderText = "Тема";
                dgvType.Name = "Type";
                dgvType.HeaderText = "Тип";
                dgvPriority.Name = "Priority";
                dgvPriority.HeaderText = "Приоритет";
                dgvUser.Name = "User";
                dgvUser.HeaderText = "Исполнитель";
                dgvDescription.Name = "Description";
                dgvDescription.HeaderText = "Описание";
                dgvIdTask.Visible = false;
                dgvViewer.Columns.Add(dgvIdTask);
                dgvViewer.Columns.Add(dgvTask);
                dgvViewer.Columns.Add(dgvProject);
                dgvViewer.Columns.Add(dgvTheme);
                dgvViewer.Columns.Add(dgvType);
                dgvViewer.Columns.Add(dgvPriority);
                dgvViewer.Columns.Add(dgvUser);
                dgvViewer.Columns.Add(dgvDescription);
                for (int i = 0; i < dTable.Rows.Count; i++)
                    dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
