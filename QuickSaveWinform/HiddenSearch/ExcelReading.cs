using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace HiddenSearch
{
    class ExcelReading
    {
        private static string verifyString(string str)
        {
            if (str == null)
            {
                return "";
            }

            return str;
        }

        public static List<HandbookObject> getExcelFile(string fileName)
        {
            List<HandbookObject> lstHandbookObj = new List<HandbookObject>();

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 1; i <= rowCount; i++)
            {
                string keyword      = "";
                string standFor     = "";
                string definition   = "";
                string howToUse     = "";
                try
                {
                    keyword = verifyString(xlRange.Cells[i, 3].Value2.ToString());
                } catch { }
                try
                {
                    standFor = verifyString(xlRange.Cells[i, 5].Value2.ToString());
                }
                catch { }
                try
                {
                    definition = verifyString(xlRange.Cells[i, 6].Value2.ToString());
                }
                catch { }
                try
                {
                    howToUse = verifyString(xlRange.Cells[i, 7].Value2.ToString());
                }
                catch { }
                HandbookObject handbookObj = new HandbookObject(keyword, standFor, definition, howToUse);
                lstHandbookObj.Add(handbookObj);
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return lstHandbookObj;
        }
    }
}
