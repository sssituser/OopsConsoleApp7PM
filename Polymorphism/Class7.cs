using System;


namespace Polymorphism
{
    class Student
    {
        public int StudentId { get; private set; }
        public string StudentName { get; private set; }
        public Student(int StudentId, string StudentName)
        {
         this.StudentId = StudentId;
         this.StudentName= StudentName;
        }
        public override string ToString()
        {
            return $"Student ID : {StudentId}\tStudent Name : {StudentName}";
        }
    }
    internal class Class7
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(111,"abc");
            Console.WriteLine(s1);
           
           
        }
    }
}
