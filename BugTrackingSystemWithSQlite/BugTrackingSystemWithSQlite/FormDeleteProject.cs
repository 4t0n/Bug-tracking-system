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
    public partial class FormDeleteProject : Form
    {
        public FormDeleteProject()
        {
            InitializeComponent();

            Form1 FormObject = new Form1(); 

            string sqlQuery;

            /*FormObject.dbConnect = new SQLiteConnection("Data Source=" + FormObject.dbFileName + ";Version=3;");
            FormObject.dbConnect.Open();
            FormObject.dbCommand.Connection = FormObject.dbConnect;*/

            DataTable dTable = new DataTable();
            sqlQuery = "SELECT * FROM ProjectList";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, FormObject.dbConnect);
            adapter.Fill(dTable);
            cbProjectNameForDelete.Items.Clear();

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                cbProjectNameForDelete.Items.Add(dTable.Rows[i].ItemArray);
            }
        }
    }
}
