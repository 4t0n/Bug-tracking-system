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

        private void bnAddProject_Click(object sender, EventArgs e)
        {
            cbProjectSelect.Items.Add(excelMod.AddCell(Convert.ToString(tbProjectName.Text)));
            tbProjectName.Clear();
        }
        private void bnDeleteProject_Click(object sender, EventArgs e)
        {
            excelMod.DeleteCell(cbProjectSelect.SelectedIndex);
        }

        private void bnCreateFile_Click(object sender, EventArgs e)
        {

           excelMod.CreateFile();
        }

        private void bnOpenFile_Click(object sender, EventArgs e)
        {
            excelMod.SaveOpenFile();
        }        
    }
}
