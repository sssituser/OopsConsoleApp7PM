using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConsoleApp7PM
{
    class Patient
    {
        // Private variables can't be accessed out side of the class and they can't be inherited
        private int p_id;
        private string p_name;

        private int p_age; // These are class variables or Global variables

        public void SetPatient(int id,string name,int age/*local variables*/)
        { 
            p_id = id;
            p_name = name;
            p_age = age;

        }
        public void GetPatient()
        {
            Console.WriteLine($"Patient Id : {p_id}\tPatient Name : {p_name}\tPatient Age : {p_age}");
        }


    }
    internal class Class12
    {
        public static void Main()
        {
            Patient p1 = new Patient();
            p1.SetPatient(111, "abc", 23);
            p1.GetPatient();
          
        }
    }
}
