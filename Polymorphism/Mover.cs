using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Mover
    {
        public void Add(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
        public void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void Add(string num1, string num2)
        {
            Console.WriteLine(num1 + num2);
        }

    }
}
