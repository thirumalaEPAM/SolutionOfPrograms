using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
namespace DataDrivenFramework
{
    public class ExcelMethods
    {
        public excel.Application Application { get; set; }
        public excel.Workbook Workbook { get; set; }
        public excel.Workbooks Workbooks { get; set; }
        public excel.Sheets sheets { get; set; }

        public excel.Worksheets worksheets { get; set; }
        public void getData(string path,string sheetName)
        {
            Application = new excel.Application();
            Workbook = Application.Workbooks.Open(path);
            sheets = Workbook.Worksheets;
           var worksheets1 = (excel.Worksheet)sheets.get_Item(sheetName);
             var range = worksheets1.UsedRange;

            for (int rowCnt = 1; rowCnt <= range.Rows.Count; rowCnt++)
            {
                for (int colCnt = 1; colCnt <= range.Rows.Count; colCnt++)
                {
                    string str = (string)(range.Cells[rowCnt, colCnt] as excel.Range).Value2;
                    System.Console.WriteLine(str);
                }

            }
        }
    }
}
