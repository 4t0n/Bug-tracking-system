using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace BugTrackingSystemWithExcel
{
    class ExcelMod
    {
        public Application ex;
        public Worksheet projectSheet;
        public Worksheet taskSheet;
        public Worksheet userSheet;
        public Workbook workBook;
        
        public void CreateFile()
        {
            //Создание файла, книги и листов
            ex = new Microsoft.Office.Interop.Excel.Application();
            workBook = ex.Workbooks.Add(Type.Missing);
            workBook.Sheets.Add(Type.Missing, Type.Missing, 2, Type.Missing);
            projectSheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            taskSheet = (Excel.Worksheet)ex.Worksheets.get_Item(2);
            userSheet = (Excel.Worksheet)ex.Worksheets.get_Item(3);
            projectSheet.Name = "Проекты";
            taskSheet.Name = "Задачи";
            userSheet.Name = "Пользователи";
            projectSheet.Cells[1, 1] = "№";
            projectSheet.Cells[1, 2] = "Название проекта";
            projectSheet.Cells.EntireColumn.AutoFit();
        }

        public void SaveOpenFile()
        {
            //Сохранение и открытие файла
            ex.Application.ActiveWorkbook.SaveAs("BugTrackingSystem.xlsx",
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            ex.Visible = true;
        }

        public string AddCell(string tbProjectName)
        {
            //Добавление номера и названия проекта, вставка в cbProjectSelect
            int i = 2;
            Excel.Range forSel1 = projectSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forSel2 = projectSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac = projectSheet.Cells[i, 1] as Excel.Range;
            projectSheet.Cells.EntireColumn.AutoFit();
            if (forYac.Text == String.Empty)
            {
                projectSheet.Cells[i, 1] = i - 1;
                projectSheet.Cells[i, 2] = tbProjectName;
                return "№ " + forSel1.Text + " " + forSel2.Text;
            }
            else
            {
                while (forYac.Text != String.Empty)
                {
                    forYac = projectSheet.Cells[i, 1] as Excel.Range;
                    forSel1 = projectSheet.Cells[i, 1] as Excel.Range;
                    forSel2 = projectSheet.Cells[i, 2] as Excel.Range;
                    i++;
                }
                projectSheet.Cells[i - 1, 1] = i - 2;
                projectSheet.Cells[i - 1, 2] = tbProjectName;
                return "№ " + forSel1.Text + " " + forSel2.Text;
            }                       
        }

        public void DeleteCell(int cbProjectIndex)
        {
            int i = 2;
            Excel.Range forYac1 = projectSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forYac2 = projectSheet.Cells[i, 2] as Excel.Range;
            while (forYac1.Text != Convert.ToString(cbProjectIndex+1))
            {
                forYac1 = projectSheet.Cells[i, 1] as Excel.Range;
                forYac2 = projectSheet.Cells[i, 2] as Excel.Range;
                i++;
            }
            forYac1.Clear();
            forYac2.Clear();
            forYac1 = projectSheet.Cells[i, 1] as Excel.Range;
            forYac2 = projectSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac1Pos = projectSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forYac2Pos = projectSheet.Cells[i, 2] as Excel.Range;
            while (forYac1.Text != String.Empty)
            {
                forYac1 = projectSheet.Cells[i, 1] as Excel.Range;
                forYac2 = projectSheet.Cells[i, 2] as Excel.Range;
                forYac1Pos = forYac1;
                forYac2Pos = forYac2;
                projectSheet.Cells[i - 1, 1] = forYac1Pos.Text;
                projectSheet.Cells[i - 1, 2] = forYac2Pos.Text;
                i++;
            }            
        }
    }
}
