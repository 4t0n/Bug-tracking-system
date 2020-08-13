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
            userSheet.Cells[1, 1] = "№";
            userSheet.Cells[1, 2] = "Имя";
            taskSheet.Cells[1, 1] = "№";
            taskSheet.Cells[1, 2] = "Проект";
            taskSheet.Cells[1, 3] = "Тема";
            taskSheet.Cells[1, 4] = "Тип";
            taskSheet.Cells[1, 5] = "Приоритет";
            taskSheet.Cells[1, 6] = "Исполнитель";
            taskSheet.Cells[1, 7] = "Описание";
            projectSheet.Cells.EntireColumn.AutoFit();
            userSheet.Cells.EntireColumn.AutoFit();
            taskSheet.Cells.EntireColumn.AutoFit();
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


        //БЛОК РАБОТЫ С ПРОЕКТАМИ
        public string AddCellProject(string tbProjectName)
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

        public void DeleteCellProject(int cbProjectIndex)
        {
            //Удаление проекта и смещение оставшихся вверх
            int i = 2;
            Excel.Range forYac1 = projectSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forYac2 = projectSheet.Cells[i, 2] as Excel.Range;
            while (forYac1.Text != Convert.ToString(cbProjectIndex+1))
            {
                forYac1 = projectSheet.Cells[i, 1] as Excel.Range;
                forYac2 = projectSheet.Cells[i, 2] as Excel.Range;
                i++;
            }

            int j = 2;            
            Excel.Range forYacTask2 = taskSheet.Cells[j, 2] as Excel.Range;            
            while (forYacTask2.Text != String.Empty)
            {                
                forYacTask2 = taskSheet.Cells[j, 2] as Excel.Range;             
                
                if (forYacTask2.Text == "№ " + forYac1.Text + " " + forYac2.Text)
                {
                    DeleteCellTask(j - 2);
                    j--;
                }
                j++;
            }


            forYac1.Clear();
            forYac2.Clear();
            
            //Смещение вверх
            if (i == 2)
            {
                i++;
            }
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
            if (i==5)
            {
                projectSheet.Cells[2, 1] = 1;
            }
            //Нумерация проектов            
            i = 3;            
            Excel.Range forYac = projectSheet.Cells[i, 1] as Excel.Range;
            projectSheet.Cells.EntireColumn.AutoFit();                        
            
            while (forYac.Text != String.Empty)
            {
                forYac = projectSheet.Cells[i, 1] as Excel.Range;                
                i++;
                projectSheet.Cells[i - 2, 1] = i - 3;
            }                       
        }

        public string[] CombBListProject(int cbCount)
        {
            //Перезаполнение cbProjectSelect
            int i = 2;
            string[] arr = new string[cbCount];
            Excel.Range forSel1 = projectSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forSel2 = projectSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac = projectSheet.Cells[i, 1] as Excel.Range;
            projectSheet.Cells.EntireColumn.AutoFit();

            while (forYac.Text != String.Empty)
            {
                forYac = projectSheet.Cells[i, 1] as Excel.Range;
                forSel1 = projectSheet.Cells[i, 1] as Excel.Range;
                forSel2 = projectSheet.Cells[i, 2] as Excel.Range;
                if (forSel1.Text == String.Empty)
                {
                    break;
                }
                arr[i-2] = "№ " + forSel1.Text + " " + forSel2.Text;
                i++;                
            }            
            return arr;
        }


        //БЛОК РАБОТЫ С ПОЛЬЗОВАТЕЛЯМИ

        public string AddCellUser(string tbUserName)
        {
            //Добавление номера и имени пользователя, вставка в cbUserSelect
            int i = 2;
            Excel.Range forSel1 = userSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forSel2 = userSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac = userSheet.Cells[i, 1] as Excel.Range;
            userSheet.Cells.EntireColumn.AutoFit();
            if (forYac.Text == String.Empty)
            {
                userSheet.Cells[i, 1] = i - 1;
                userSheet.Cells[i, 2] = tbUserName;
                return "№ " + forSel1.Text + " " + forSel2.Text;
            }
            else
            {
                while (forYac.Text != String.Empty)
                {
                    forYac = userSheet.Cells[i, 1] as Excel.Range;
                    forSel1 = userSheet.Cells[i, 1] as Excel.Range;
                    forSel2 = userSheet.Cells[i, 2] as Excel.Range;
                    i++;
                }
                userSheet.Cells[i - 1, 1] = i - 2;
                userSheet.Cells[i - 1, 2] = tbUserName;
                return "№ " + forSel1.Text + " " + forSel2.Text;
            }
        }

        public void DeleteCellUser(int cbUserIndex)
        {
            //Удаление пользователя и смещение оставшихся вверх
            int i = 2;
            Excel.Range forYac1 = userSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forYac2 = userSheet.Cells[i, 2] as Excel.Range;
            while (forYac1.Text != Convert.ToString(cbUserIndex + 1))
            {
                forYac1 = userSheet.Cells[i, 1] as Excel.Range;
                forYac2 = userSheet.Cells[i, 2] as Excel.Range;
                i++;
            }
            forYac1.Clear();
            forYac2.Clear();

            //Смещение вверх
            if (i == 2)
            {
                i++;
            }
            forYac1 = userSheet.Cells[i, 1] as Excel.Range;
            forYac2 = userSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac1Pos = userSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forYac2Pos = userSheet.Cells[i, 2] as Excel.Range;
            while (forYac1.Text != String.Empty)
            {
                forYac1 = userSheet.Cells[i, 1] as Excel.Range;
                forYac2 = userSheet.Cells[i, 2] as Excel.Range;
                forYac1Pos = forYac1;
                forYac2Pos = forYac2;
                userSheet.Cells[i - 1, 1] = forYac1Pos.Text;
                userSheet.Cells[i - 1, 2] = forYac2Pos.Text;
                i++;
            }
            if (i == 5)
            {
                userSheet.Cells[2, 1] = 1;
            }
            //Нумерация пользователей
            i = 3;
            Excel.Range forYac = userSheet.Cells[i, 1] as Excel.Range;
            userSheet.Cells.EntireColumn.AutoFit();

            while (forYac.Text != String.Empty)
            {
                forYac = userSheet.Cells[i, 1] as Excel.Range;
                i++;
                userSheet.Cells[i - 2, 1] = i - 3;
            }
        }

        public string[] CombBListUser(int cbCount)
        {
            //Перезаполнение cbUserSelect
            int i = 2;
            string[] arr = new string[cbCount];
            Excel.Range forSel1 = userSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forSel2 = userSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac = userSheet.Cells[i, 1] as Excel.Range;
            userSheet.Cells.EntireColumn.AutoFit();

            while (forYac.Text != String.Empty)
            {
                forYac = userSheet.Cells[i, 1] as Excel.Range;
                forSel1 = userSheet.Cells[i, 1] as Excel.Range;
                forSel2 = userSheet.Cells[i, 2] as Excel.Range;
                if (forSel1.Text == String.Empty)
                {
                    break;
                }
                arr[i - 2] = "№ " + forSel1.Text + " " + forSel2.Text;
                i++;
            }
            return arr;
        }


        //БЛОК РАБОТЫ С ЗАДАЧАМИ

        public string AddCellTask(string cbTaskProject, string tbTaskTheme, string tbTaskType, string tbTaskPriority, string cbTaskUser, string tbTaskDescription)
        {
            //Добавление задачи с данными, вставка в cbTaskSelect
            int i = 2;
            Excel.Range forSel1 = taskSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forSel2 = taskSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forSel3 = taskSheet.Cells[i, 3] as Excel.Range;
            Excel.Range forSel4 = taskSheet.Cells[i, 4] as Excel.Range;
            Excel.Range forSel5 = taskSheet.Cells[i, 5] as Excel.Range;
            Excel.Range forSel6 = taskSheet.Cells[i, 6] as Excel.Range;
            Excel.Range forSel7 = taskSheet.Cells[i, 7] as Excel.Range;
            Excel.Range forYac = taskSheet.Cells[i, 1] as Excel.Range;
            taskSheet.Cells.EntireColumn.AutoFit();
            if (forYac.Text == String.Empty)
            {
                taskSheet.Cells[i, 1] = i - 1;
                taskSheet.Cells[i, 2] = cbTaskProject;
                taskSheet.Cells[i, 3] = tbTaskTheme;
                taskSheet.Cells[i, 4] = tbTaskType;
                taskSheet.Cells[i, 5] = tbTaskPriority;
                taskSheet.Cells[i, 6] = cbTaskUser;
                taskSheet.Cells[i, 7] = tbTaskDescription;                
                return "№" + forSel1.Text + " " + forSel2.Text + " " + forSel3.Text + " " + forSel4.Text + " " + forSel5.Text + " " + forSel6.Text + " " + forSel7.Text;
            }
            else
            {
                while (forYac.Text != String.Empty)
                {
                    forYac = taskSheet.Cells[i, 1] as Excel.Range;
                    forSel1 = taskSheet.Cells[i, 1] as Excel.Range;
                    forSel2 = taskSheet.Cells[i, 2] as Excel.Range;
                    forSel3 = taskSheet.Cells[i, 3] as Excel.Range;
                    forSel4 = taskSheet.Cells[i, 4] as Excel.Range;
                    forSel5 = taskSheet.Cells[i, 5] as Excel.Range;
                    forSel6 = taskSheet.Cells[i, 6] as Excel.Range;
                    forSel7 = taskSheet.Cells[i, 7] as Excel.Range;
                    i++;
                }
                taskSheet.Cells[i - 1, 1] = i - 2;
                taskSheet.Cells[i - 1, 2] = cbTaskProject;
                taskSheet.Cells[i - 1, 3] = tbTaskTheme;
                taskSheet.Cells[i - 1, 4] = tbTaskType;
                taskSheet.Cells[i - 1, 5] = tbTaskPriority;
                taskSheet.Cells[i - 1, 6] = cbTaskUser;
                taskSheet.Cells[i - 1, 7] = tbTaskDescription;                
                return "№" + forSel1.Text + " " + forSel2.Text + " " + forSel3.Text + " " + forSel4.Text + " " + forSel5.Text + " " + forSel6.Text + " " + forSel7.Text;
            }
            
        }

        public void DeleteCellTask(int cbTaskIndex)
        {
            //Удаление задачи и смещение оставшихся вверх
            int i = 2;
            Excel.Range forYac1 = taskSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forYac2 = taskSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac3 = taskSheet.Cells[i, 3] as Excel.Range;
            Excel.Range forYac4 = taskSheet.Cells[i, 4] as Excel.Range;
            Excel.Range forYac5 = taskSheet.Cells[i, 5] as Excel.Range;
            Excel.Range forYac6 = taskSheet.Cells[i, 6] as Excel.Range;
            Excel.Range forYac7 = taskSheet.Cells[i, 7] as Excel.Range;
            while (forYac1.Text != Convert.ToString(cbTaskIndex + 1))
            {
                forYac1 = taskSheet.Cells[i, 1] as Excel.Range;
                forYac2 = taskSheet.Cells[i, 2] as Excel.Range;
                forYac3 = taskSheet.Cells[i, 3] as Excel.Range;
                forYac4 = taskSheet.Cells[i, 4] as Excel.Range;
                forYac5 = taskSheet.Cells[i, 5] as Excel.Range;
                forYac6 = taskSheet.Cells[i, 6] as Excel.Range;
                forYac7 = taskSheet.Cells[i, 7] as Excel.Range;
                i++;
            }
            forYac1.Clear();
            forYac2.Clear();
            forYac3.Clear();
            forYac4.Clear();
            forYac5.Clear();
            forYac6.Clear();
            forYac7.Clear();

            //Смещение вверх
            if (i == 2)
            {
                i++;
            }
            forYac1 = taskSheet.Cells[i, 1] as Excel.Range;
            forYac2 = taskSheet.Cells[i, 2] as Excel.Range;
            forYac3 = taskSheet.Cells[i, 3] as Excel.Range;
            forYac4 = taskSheet.Cells[i, 4] as Excel.Range;
            forYac5 = taskSheet.Cells[i, 5] as Excel.Range;
            forYac6 = taskSheet.Cells[i, 6] as Excel.Range;
            forYac7 = taskSheet.Cells[i, 7] as Excel.Range;
            Excel.Range forYac1Pos = taskSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forYac2Pos = taskSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forYac3Pos = taskSheet.Cells[i, 3] as Excel.Range;
            Excel.Range forYac4Pos = taskSheet.Cells[i, 4] as Excel.Range;
            Excel.Range forYac5Pos = taskSheet.Cells[i, 5] as Excel.Range;
            Excel.Range forYac6Pos = taskSheet.Cells[i, 6] as Excel.Range;
            Excel.Range forYac7Pos = taskSheet.Cells[i, 7] as Excel.Range;
            while (forYac1.Text != String.Empty)
            {
                forYac1 = taskSheet.Cells[i, 1] as Excel.Range;
                forYac2 = taskSheet.Cells[i, 2] as Excel.Range;
                forYac3 = taskSheet.Cells[i, 3] as Excel.Range;
                forYac4 = taskSheet.Cells[i, 4] as Excel.Range;
                forYac5 = taskSheet.Cells[i, 5] as Excel.Range;
                forYac6 = taskSheet.Cells[i, 6] as Excel.Range;
                forYac7 = taskSheet.Cells[i, 7] as Excel.Range;
                forYac1Pos = forYac1;
                forYac2Pos = forYac2;
                forYac3Pos = forYac3;
                forYac4Pos = forYac4;
                forYac5Pos = forYac5;
                forYac6Pos = forYac6;
                forYac7Pos = forYac7;
                taskSheet.Cells[i - 1, 1] = forYac1Pos.Text;
                taskSheet.Cells[i - 1, 2] = forYac2Pos.Text;
                taskSheet.Cells[i - 1, 3] = forYac3Pos.Text;
                taskSheet.Cells[i - 1, 4] = forYac4Pos.Text;
                taskSheet.Cells[i - 1, 5] = forYac5Pos.Text;
                taskSheet.Cells[i - 1, 6] = forYac6Pos.Text;
                taskSheet.Cells[i - 1, 7] = forYac7Pos.Text;
                i++;
            }
            if (i == 5)
            {
                taskSheet.Cells[2, 1] = 1;
            }
            //Нумерация задач
            i = 3;
            Excel.Range forYac = taskSheet.Cells[i, 1] as Excel.Range;
            taskSheet.Cells.EntireColumn.AutoFit();

            while (forYac.Text != String.Empty)
            {
                forYac = taskSheet.Cells[i, 1] as Excel.Range;
                i++;
                taskSheet.Cells[i - 2, 1] = i - 3;
            }
        }

        public string[] CombBListTask(int cbCount)
        {
            //Перезаполнение cbTaskSelect
            int i = 2;
            string[] arr = new string[cbCount];
            Excel.Range forSel1 = taskSheet.Cells[i, 1] as Excel.Range;
            Excel.Range forSel2 = taskSheet.Cells[i, 2] as Excel.Range;
            Excel.Range forSel3 = taskSheet.Cells[i, 3] as Excel.Range;
            Excel.Range forSel4 = taskSheet.Cells[i, 4] as Excel.Range;
            Excel.Range forSel5 = taskSheet.Cells[i, 5] as Excel.Range;
            Excel.Range forSel6 = taskSheet.Cells[i, 6] as Excel.Range;
            Excel.Range forSel7 = taskSheet.Cells[i, 7] as Excel.Range;
            Excel.Range forYac = taskSheet.Cells[i, 1] as Excel.Range;
            taskSheet.Cells.EntireColumn.AutoFit();

            while (forYac.Text != String.Empty)
            {
                forYac = taskSheet.Cells[i, 1] as Excel.Range;
                forSel1 = taskSheet.Cells[i, 1] as Excel.Range;
                forSel2 = taskSheet.Cells[i, 2] as Excel.Range;
                forSel3 = taskSheet.Cells[i, 3] as Excel.Range;
                forSel4 = taskSheet.Cells[i, 4] as Excel.Range;
                forSel5 = taskSheet.Cells[i, 5] as Excel.Range;
                forSel6 = taskSheet.Cells[i, 6] as Excel.Range;
                forSel7 = taskSheet.Cells[i, 7] as Excel.Range;
                if (forSel1.Text == String.Empty)
                {
                    break;
                }
                arr[i - 2] = "№" + forSel1.Text + " " + forSel2.Text + " " + forSel3.Text + " " + forSel4.Text + " " + forSel5.Text + " " + forSel6.Text + " " + forSel7.Text;
                i++;
            }
            return arr;
        }
    }
}
