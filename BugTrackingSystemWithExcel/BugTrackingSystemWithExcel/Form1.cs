using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace BugTrackingSystemWithExcel
{    
    public partial class Form1 : Form
    {
        Projects projects = new Projects();
        ExcelMod excelMod = new ExcelMod();
        public Form1()
        {
            InitializeComponent();
            
        }
        //Создание файла
        private void bnCreateFile_Click(object sender, EventArgs e)
        {
            excelMod.CreateFile();
        }
        //Сохранение и открытие файла
        private void bnOpenFile_Click(object sender, EventArgs e)
        {
            excelMod.SaveOpenFile();
        }


        //Добавление проекта
        private void bnAddProject_Click(object sender, EventArgs e)
        {
            string ProjectName = excelMod.AddCellProject(Convert.ToString(tbProjectName.Text));
            cbProjectSelect.Items.Add(ProjectName);
            cbTaskProject.Items.Add(ProjectName);
            tbProjectName.Clear();
        }
        //Удаление проекта
        private void bnDeleteProject_Click(object sender, EventArgs e)
        {
            int cbCount = cbProjectSelect.Items.Count;
            int cbCountTask = cbTaskSelect.Items.Count;
            int cbCountTaskSelect = excelMod.DeleteCellProject(cbProjectSelect.SelectedIndex);
            cbProjectSelect.Items.Clear();
            cbTaskProject.Items.Clear();
            cbTaskSelect.Items.Clear();
            cbProjectSelect.Items.AddRange(excelMod.CombBListProject(cbCount-1));
            cbTaskProject.Items.AddRange(excelMod.CombBListProject(cbCount - 1));
            cbTaskSelect.Items.AddRange(excelMod.CombBListTask(cbCountTask - cbCountTaskSelect));
        }
                
        //Добавление пользователя
        private void bnAddUser_Click(object sender, EventArgs e)
        {
            string UserName = excelMod.AddCellUser(Convert.ToString(tbUserName.Text));
            cbUserSelect.Items.Add(UserName);
            cbTaskUser.Items.Add(UserName);
            tbUserName.Clear();
        }
        //Удаление пользователя
        private void bnDeleteUser_Click(object sender, EventArgs e)
        {
            int cbCount = cbUserSelect.Items.Count;
            int cbCountTask = cbTaskSelect.Items.Count;
            int cbCountTaskSelect = excelMod.DeleteCellUser(cbUserSelect.SelectedIndex);            
            cbUserSelect.Items.Clear();
            cbTaskUser.Items.Clear();
            cbTaskSelect.Items.Clear();
            cbUserSelect.Items.AddRange(excelMod.CombBListUser(cbCount - 1));
            cbTaskUser.Items.AddRange(excelMod.CombBListUser(cbCount - 1));
            cbTaskSelect.Items.AddRange(excelMod.CombBListTask(cbCountTask - cbCountTaskSelect));
        }


        //Добавление задачи
        private void bnAddTask_Click(object sender, EventArgs e)
        {
            cbTaskSelect.Items.Add(excelMod.AddCellTask(cbTaskProject.SelectedItem.ToString(),tbTaskTheme.Text,tbTaskType.Text,tbTaskPriority.Text,
                cbTaskUser.SelectedItem.ToString(),tbTaskDescription.Text));
        }
        //Удаление задачи
        private void bnDeleteTask_Click(object sender, EventArgs e)
        {
            int cbCount = cbTaskSelect.Items.Count;
            excelMod.DeleteCellTask(cbTaskSelect.SelectedIndex);
            cbTaskSelect.Items.Clear();            
            cbTaskSelect.Items.AddRange(excelMod.CombBListTask(cbCount - 1));            
        }

        private void bnGetUsers_Click(object sender, EventArgs e)
        {
            tbList.Clear();
            tbList.Text = "СПИСОК ПОЛЬЗОВАТЕЛЕЙ" + Environment.NewLine + "№   Имя пользователя" + Environment.NewLine;
            for (int i = 0; i < excelMod.getUsers().Count; i++)
            {                
                tbList.Text += Convert.ToString(excelMod.getUsers()[i]) + Environment.NewLine;
            }            
        }

        private void bnGetProjects_Click(object sender, EventArgs e)
        {
            tbList.Clear();
            tbList.Text = "СПИСОК ПРОЕКТОВ" + Environment.NewLine + "№   Название проекта" + Environment.NewLine;
            for (int i = 0; i < excelMod.getProjects().Count; i++)
            {
                tbList.Text += Convert.ToString(excelMod.getProjects()[i]) + Environment.NewLine;
            }
        }
    }
}
