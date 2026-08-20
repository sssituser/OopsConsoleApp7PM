using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorExamples
{
    internal class Employee
    {
        public int EmployeeId { get; private set; }

        public  string ? EmployeeName { get; private set; }

        public int EmployeeSalary { get; private set; }

        public void SetEmployee(int EmployeeId,string EmployeeName,int EmployeeSalary)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeSalary;
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employee ID : {EmployeeId}\tEmployeeName : {EmployeeName}\tEmployee Salary : {EmployeeSalary}");
        }
    }
}
