using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee : Department
    {
        private int EmPId;
        private string EmployeeName;

        private int EmployeeSal;
        public Employee(int EmPId, string EmployeeName, int EmployeeSal,int DeptId,string DeptName):base(DeptId, DeptName)
        {
            this.EmPId = EmPId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSal = EmployeeSal;
        }
        public void GetEmployee()
        {
            Console.WriteLine($"EmployeeId :{EmPId}\tEmployee Name : {EmployeeName}\tEmployee Salary : {EmployeeSal}");
            GetDepartment();
        }
    }
}
