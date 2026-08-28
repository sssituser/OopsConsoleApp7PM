using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuhanaSystem
{
    public class SuhanaConsole
    {
        public static void Print(string value)
        {
            Console.Write(value);
        }
        public static void PrintLine(string value)
        {
            Console.WriteLine(value);
        }
        public static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
        public static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
