using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace ConstructorExamples
{
    internal class Class1
    {
        public static void Main()
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.GetStudet();
            s2.GetStudet();
            Console.WriteLine("==========================s3 object============");
            Student s3 = new Student(112,"Kiran",500);
           
            Student s4 = new Student(114, "Lakshmi", 550);
            Student s5 = new Student(115, "Suhana", 550);
            s3.GetStudet();
            s4.GetStudet();
            s5.GetStudet();
            Console.WriteLine("==========================s6 object============");
            Student s6 = new Student(s3);
            s6.GetStudet();

        }
    }
}
