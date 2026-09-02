using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenerics
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public override string ToString()
        {
            return $"Employee ID : {EmployeeId}\tEmployeeName : {EmployeeName}";
        }
    }
}
