using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Test
    {
        public static void Show(int x)
        {
            Console.WriteLine(x);
        }
        public static void Show(double x)
        {
            Console.WriteLine(x);
        }
        public static void Show(string x)
        {
            Console.WriteLine(x);
        }
        public static void Show(bool x)
        {
            Console.WriteLine(x);
        }
        public static void Show(char x)
        {
            Console.WriteLine(x);
        }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            Test.Show(1);
            Test.Show(1.7);
            Test.Show("abc");
            Test.Show(true);
            Test.Show('8');
        }
    }
}
