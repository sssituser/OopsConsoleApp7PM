using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrosHandling
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Marks : ");
                    int marks = int.Parse(Console.ReadLine());
                    if (marks < 0 || marks > 100)
                    {
                        throw new InvalidMarksException("Hey Iam From Try Block Got Invalid Marks");
                    }
                    if (marks > 34)
                    {
                        Console.WriteLine("You Got Passed In the Exam");
                    }
                    else
                    {
                        Console.WriteLine("You Got Failed in the Exam");
                    }

                }
                catch (InvalidMarksException Ix)
                {
                    Console.WriteLine($"Enter Marks In between 0 To 100:{Ix.Message}");
                }
                catch (FormatException Ix)
                {
                    Console.WriteLine("Enter only Numbers with out decimal values");
                }
               
            }
            
        }
    }
}
