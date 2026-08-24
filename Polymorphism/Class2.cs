using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Class1 res = new Class1();
            res.Area(5);
            res.Area(5, 2);
            res.Area(5.2);
        }
    }
}
