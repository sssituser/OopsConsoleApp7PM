using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OopsConsoleApp7PM
{
    internal class Student
    {
     private   int studentId;
        string studentName;
        int studentAge;
        int studentMarks;
        static string collegeName = "SSSIT";
        static string collegeAddress ="KPHB";

        public static string CollegName
        {
            get
            {
                return collegeName;
            }
        }
        public static string CollegeAddress
        {
            get
            {
                return collegeAddress;
            }
        }
        public int StudentId
        {
           
            set
            {
                studentId = value;
            }
        }
       public string StudentName
        {
            set
            {
                studentName = value;
            }
        }
        public int StudentAge
        {
            set
            {
                studentAge = value;
            }
        }
        public int StudentMarks
        {
            set
            {
                studentMarks = value;
            }
        }
    }
}
