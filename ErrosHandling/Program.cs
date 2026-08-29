using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrosHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter num1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Hi Iam the Exception Object Message from try block");
                    }
                    Console.WriteLine($"Quo is : {num1 / num2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter Only Integers"); 
                }
                catch (DivideByZeroException dx)
                {
                    Console.WriteLine($"num2 can't be zero : =>{dx.Message}");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"{ex}==>{ex.Message}");
                }
                
            }
        }
    }
}
