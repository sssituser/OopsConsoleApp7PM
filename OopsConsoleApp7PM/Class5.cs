using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class5
    {
        public static void Main()
        {

            // static members can be accessed using class name
            Employee.companyName = "SSSIT";
            Employee.companyAddress = "KPHB";   // Product , Student

            Employee emp1 = new Employee();
            emp1.employeeId = 111; // Writing the data
            emp1.empName = "abc";
            emp1.empSal = 50000;

            Employee emp2 = new Employee();
            emp2.employeeId = 222; // Writing the data
            emp2.empName = "def";
            emp2.empSal = 60000;

            //Reading the data
            Console.WriteLine("EmpId\tEmpName\tEmpSal");
            Console.WriteLine($"{emp1.employeeId}\t{emp1.empName}\t{emp1.empSal}"); // Reading the data
            Console.WriteLine($"{emp2.employeeId}\t{emp2.empName}\t{emp2.empSal}"); // Reading the data
            Console.WriteLine($"{Employee.companyName}\t{Employee.companyAddress}");
        }
    }
}
