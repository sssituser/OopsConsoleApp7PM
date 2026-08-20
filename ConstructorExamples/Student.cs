using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorExamples
{
    internal class Student
    {
        private int student_id;
        private string student_name;
        private int student_marks;
        public Student() // construtor without parametres and it default constructor
        {
           
            student_id = 111;
            student_name = "abc";
            student_marks = 100;
        }

        public Student(int student_id, string student_name,int student_marks)
        {
           
            this.student_id = student_id;
            this.student_name = student_name;
            this.student_marks = student_marks;
        }
       
        public Student(Student stu)
        {
           
           student_id=stu.student_id;
           student_name=stu.student_name;
           student_marks=stu.student_marks;
        }
        public void GetStudet()
        {
            Console.WriteLine($"StudentId : {student_id}\tStudent Name : {student_name}\tStudent Marks : {student_marks}");
        }
        static Student()
        {
            Console.WriteLine("Hi Iam Static Constructor");
        }
    }
}
