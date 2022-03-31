using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
namespace DataDrivenExcel
{
    public class ExcelCommonMethods
    {

        public excel.Application Application { get; set; }
        public excel.Workbook Workbook { get; set; }
        public excel.Workbooks Workbooks { get; set; }
        public excel.Sheets sheets { get; set; }

        public excel.Worksheets worksheets { get; set; }

        Hashtable EmployeeData = new Hashtable();

        Employee emp=null;
        public Hashtable getData(string path, string sheetName)
        {
            Application = new excel.Application();
            Workbook = Application.Workbooks.Open(path);
            sheets = Workbook.Worksheets;
            var worksheets1 = (excel.Worksheet)sheets.get_Item(sheetName);
            var range = worksheets1.UsedRange;

            for (int rowCnt = 2; rowCnt <= range.Rows.Count; rowCnt++)
            {
                emp=new Employee();

                var str = (range.Cells[rowCnt, 1] as excel.Range).Value2;
                emp.Id=((range.Cells[rowCnt, 1] as excel.Range).Value2);
                emp.Name= (String)((range.Cells[rowCnt, 2] as excel.Range).Value2);
                emp.Salary= ((range.Cells[rowCnt, 3] as excel.Range).Value2);
                emp.Place= (String)((range.Cells[rowCnt, 4] as excel.Range).Value2);
                emp.DeptName= (String)((range.Cells[rowCnt, 5] as excel.Range).Value2);
                emp.ManagerId= ((range.Cells[rowCnt, 6] as excel.Range).Value2);


               
                EmployeeData.Add(rowCnt, emp);
            }
            return EmployeeData;
        }
        public void AllEmployeesLocation(string path, string sheetName)
        {
            var employee = getData(path, sheetName);

            var EmpRecorcds = employee.Values.Cast<Employee>().Where(x => x.Place=="Hyderabad").ToList();

            Console.WriteLine("Employees whose location is Hyderabad :");
            displayEmplayees(EmpRecorcds);
            
            var EmpSal = employee.Values.Cast<Employee>().Where(x => x.Salary >40000).ToList();
            Console.WriteLine("Employees whose Salary > 40k ");
            displayEmplayees(EmpSal);
        }

        public void displayEmplayees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine("EmployeeID : {0} ,EmployeeName : {1},Salary:{2},place :{3},ZdeptName : {4}", emp.Id, emp.Name, emp.Salary, emp.Place, emp.DeptName);
            }
        }
    }

   
}
