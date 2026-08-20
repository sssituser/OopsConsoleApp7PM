using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class11
    {
        public static void Main()
        {
            Company c1 = new Company();
            c1.SetCompany(111,"abc","def");

            Console.WriteLine(c1.CompanyId);
            Console.WriteLine(c1.CompanyName);
            Console.WriteLine(c1.CompanyAddress);

           Company c2 = new Company();
            c2.SetCompany(112, "lmn", "ppp");
            Console.WriteLine(c2.CompanyId);
            Console.WriteLine(c2.CompanyName);
            Console.WriteLine(c2.CompanyAddress);

            
        }
    }
}
