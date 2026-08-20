using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OopsConsoleApp7PM
{
    /*
     * Method is calling its own method
     * 
     * **/
    internal class Class4
    {
        public static int Sum(int num) // sum 5 numbers = 15
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return num + Sum(num - 1);
            }
        }
        public static int Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5));
            Console.WriteLine(Factorial(5));
           
        }
    }
}
