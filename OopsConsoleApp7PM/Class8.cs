using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class8
    {
        public static void Main()
        {
            Product p1 = new Product();
            p1.ProductId = 111;
            p1.ProductName = "Test";
            p1.ProductPrice = 100;  // Writing the Data

            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.ProductName);
            Console.WriteLine(p1.ProductPrice);

        }
    }
}
