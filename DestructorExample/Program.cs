using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorExample
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        ~Employee()
        {
            Console.WriteLine("Object Destroyed");
            Console.ReadLine();
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();
            Employee emp5 = new Employee();
            Employee emp6 = new Employee();
        }
    }
}
