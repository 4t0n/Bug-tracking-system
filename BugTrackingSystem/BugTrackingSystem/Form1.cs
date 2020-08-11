using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
