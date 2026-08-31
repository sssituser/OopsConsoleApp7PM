using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ErrosHandling
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter age : ");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 0)
                    {
                        throw new InvalidageException("Hi Im in Try block");
                    }
                }
                catch (InvalidageException ix)
                {
                    Console.WriteLine($"Age Can't -ve :{ix.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
