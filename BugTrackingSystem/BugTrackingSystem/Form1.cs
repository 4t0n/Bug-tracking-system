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
namespace BugTrackingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        List<Project> projects = new List<Project>();        

        private void bnAddProject_Click(object sender, EventArgs e)
        {
            Project project = new Project(tbProjectName.Text);
            projects.Add(project);
            cbProjectForTask.Items.Add(project.Name);
            cbProjectName.Items.Add(project.Name);
            tbProjectName.Clear();
        }
        private void bnDeleteProject_Click(object sender, EventArgs e)
        {
            foreach (Project project in projects)
            {
                if (Convert.ToString(cbProjectName.SelectedItem) == project.Name)
                {
                    projects.Remove(project);
                    cbProjectForTask.Items.Remove(project.Name);
                    cbProjectName.Items.Remove(project.Name);
                    break;
                }
            }
        }

        private void bnGetProjects_Click(object sender, EventArgs e)
        {
            tbList.Clear();
            foreach (Project project in projects)
            {                
                tbList.Text += project.Name + '\r' + '\n';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.SheetsInNewWorkbook = 3;            
            Excel.Worksheet tasks = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            Excel.Worksheet projects = (Excel.Worksheet)ex.Worksheets.get_Item(2);
            Excel.Worksheet users = (Excel.Worksheet)ex.Worksheets.get_Item(3);
            tasks.Name = "Задачи";
            projects.Name = "Проекты";
            users.Name = "Пользователи";
            tasks.Cells[1, 1] = String.Format("Boom {0} {1}", 1, 1);
            Excel.Range forYach = tasks.Cells[1, 1] as Excel.Range;
            string yach = forYach.Value2.ToString();
            tasks.Cells[2, 1] = String.Format(yach, 2, 1);

            int i = 1;
            Excel.Range forYac = tasks.Cells[i, 1] as Excel.Range;            
            while (forYac.Text != String.Empty)
            {
                forYac = tasks.Cells[i, 1] as Excel.Range;
                i++;
            }
            tasks.Cells[i-1, 1] = "Boom";
            
            ex.Application.ActiveWorkbook.SaveAs("doc.xlsx", Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);            
            ex.Visible = true;
        }
    }
}
