using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace ConstructorExamples
{
    internal class Class3
    {
        public static void Main()
        {
            Console.WriteLine("=========================Laxmi's Time=================");
            SssitDotNet7Pm laxmi = new SssitDotNet7Pm();
            laxmi.CheckBalance();  // 20000
            laxmi.Spent(5000); // 5000
            Console.WriteLine("=========================Suhana's Time=================");
            SssitDotNet7Pm Suhana = new SssitDotNet7Pm();
            Suhana.CheckBalance(); // 15000
            Suhana.Spent(7000);  // 7000
            Suhana.CheckBalance(); // 8000

        }
    }
}
