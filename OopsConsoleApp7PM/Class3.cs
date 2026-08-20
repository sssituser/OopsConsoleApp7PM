using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.StudentId = 111;
            s1.StudentName = "abc";
            s1.StudentAge = 30;
            s1.StudentMarks = 900;
            Console.WriteLine($"Colleget Name   : {Student.CollegName}");
            Console.WriteLine($"Colleget Address : {Student.CollegeAddress}");

           
        }
    }
}
