using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Department
    {
        private int DeptId;

        private string DeptName;

       
        public Department(int DeptId, string DeptName)
        {
            this.DeptId = DeptId;
            this.DeptName = DeptName;
        }
        public void GetDepartment()
        {
            Console.WriteLine($"Deparment ID : {DeptId}\nDepartment Name : {DeptName}");
        }
    }
}
