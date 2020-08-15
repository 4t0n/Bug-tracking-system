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
        //Создать файла
        private void toolSpFileCreate_Click(object sender, EventArgs e)
        {            
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
                        dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS ProjectList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, Project TEXT);CREATE TABLE IF NOT EXISTS UserList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, User TEXT);CREATE TABLE IF NOT EXISTS TaskList (idTask INTEGER PRIMARY KEY AUTOINCREMENT, Task TEXT, Project TEXT, Theme TEXT, Type TEXT, Priority TEXT, User TEXT, Description TEXT)";
                        dbCommand.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }                
                dbConnect.Close();
            }            
        }

        //Открыть файл
        private void toolSpFileOpen_Click(object sender, EventArgs e)
        {            
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
                    dbCommand.CommandText = "CREATE TABLE IF NOT EXISTS ProjectList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, Project TEXT);CREATE TABLE IF NOT EXISTS UserList (idProject INTEGER PRIMARY KEY AUTOINCREMENT, User TEXT);CREATE TABLE IF NOT EXISTS TaskList (idTask INTEGER PRIMARY KEY AUTOINCREMENT, Task TEXT, Project TEXT, Theme TEXT, Type TEXT, Priority TEXT, User TEXT, Description TEXT)";
                    dbCommand.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }                
                dbConnect.Close();
            }
        }

        //Добавление проекта
        private void bnAddNameProject_Click(object sender, EventArgs e)
        {
            Project project = new Project(dbFileName, dbConnect, dbCommand);
            project.AddNameProject(tbProjectName.Text);
            tbProjectName.Clear();
        }

        //Удалить проект
        private void bnDeleteProject_Click(object sender, EventArgs e)
        {
            Project project = new Project(dbFileName, dbConnect, dbCommand);
            project.DeleteNameProject();
        }

        //Добавить пользователя
        private void bnAddNameUser_Click(object sender, EventArgs e)
        {
            User user = new User(dbFileName, dbConnect, dbCommand);
            user.AddNameUser(tbUserName.Text);
            tbUserName.Clear();
        }
        
        //Удалить пользователя
        private void bnDeleteUser_Click(object sender, EventArgs e)
        {
            User user = new User(dbFileName, dbConnect, dbCommand);
            user.DeleteNameUser();
        }

        //Показать список проектов
        private void bnShowProjects_Click(object sender, EventArgs e)
        {
            Project project = new Project(dbFileName, dbConnect, dbCommand);
            project.ShowProjects(dgvViewer);
        }

        //Показать список пользователей
        private void bnShowUsers_Click(object sender, EventArgs e)
        {
            User user = new User(dbFileName, dbConnect, dbCommand);
            user.ShowUsers(dgvViewer);
        }

        //Показать список задач в проекте
        private void bnShowTasksInProject_Click(object sender, EventArgs e)
        {
            Task task = new Task(dbFileName, dbConnect, dbCommand);
            task.ShowTasks(dgvViewer);
        }

        //Показать список задач на исполнителе
        private void bnShowTasksOnUser_Click(object sender, EventArgs e)
        {

        }

        
    }    
}
