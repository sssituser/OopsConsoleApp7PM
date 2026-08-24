using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Class1
    {
        public void Area(int s)
        {
            Console.WriteLine($"Area of a Square is : {s*s}");
        }
        public void Area(int l,int b)
        {
            Console.WriteLine($"Area of a Rectagle is : {l*b}");
        }
        public void Area(double r)
        {
            Console.WriteLine($"Area of a Circle is : {3.14*r*r}");
        }
    }
}
