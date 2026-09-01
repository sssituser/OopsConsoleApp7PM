using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySystem
{
    public class Lakshmi
    {
        public void Add(int a,int b)
        {
            Console.WriteLine($"Sum is : {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Sub is : {a - b}");
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine($"Mul is : {a * b}");
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine($"Quo is : {a / b}");
        }
    }
}
