using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class10
    {
        public static void Main()
        {
            Customer c1 = new Customer() { CustomerId=112,CustomerName="pqr",CustomerAddress="def",};

            c1.CustomerId = 114;
            c1.CustomerName = "def";
            c1.CustomerAddress = "KPHB";

            Console.WriteLine(c1.CustomerId);
            Console.WriteLine(c1.CustomerName);
            Console.WriteLine(c1.CustomerAddress);
        
        }
    }
}
