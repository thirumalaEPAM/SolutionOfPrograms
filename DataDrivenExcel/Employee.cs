using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenExcel
{
    public class Employee
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string DeptName { get; set; }
        public string Place { get; set; }

        public double ManagerId { get; set; }  

    }
}
