using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrosHandling
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a number : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter a number : ");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Hi Iam in Tryblok with num2 is zero");
                    }
                    Console.WriteLine(num1 / num2);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
