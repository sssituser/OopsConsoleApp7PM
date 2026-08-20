using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class7
    { // no
        public static void Main()
        {
            Console.WriteLine(Student.CollegName);
            Console.WriteLine(Student.CollegeAddress); // Read Only
            Student s1 = new Student();
            s1.StudentId = 111;
            s1.StudentName = "abc";
            s1.StudentAge = 19;
            s1.StudentMarks = 600; // Write Only
           

        }
    }
}
