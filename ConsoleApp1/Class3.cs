using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MathsSystem;
namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Numbers n = new Numbers();
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if(n.IsPalindrome(num))
            {
                Console.WriteLine($"{num} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{num} is not a Palidrome");
            }
            Console.Write("Enter a number : ");
            num = int.Parse(Console.ReadLine()) ;
            if (n.IsAdam(num))
            {
                Console.WriteLine($"{num} is an Adam number");
            }
            else
            {
                Console.WriteLine($"{num} is not an Adam number");
            }
        }
    }
}
