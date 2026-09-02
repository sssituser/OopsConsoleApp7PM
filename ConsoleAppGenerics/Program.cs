using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test<int> p = new Test<int>();
            p.Show(10);
            Test<string> q = new Test<string>();
            q.Show("abc");

            Test<double> r = new Test<double>();
            r.Show(7.8);

            Test<Employee> emp = new Test<Employee>();
            emp.Show(new Employee() { EmployeeId = 111, EmployeeName = "abc" });

            Test<Student> stu = new Test<Student>();
            stu.Show(new Student() { StudentId = 123, StudentName = "kiran" });





        }
    }
}
