using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySystem
{
    public class LakshmiConsole
    {
        public static void WriteLine(string val)
        {
            Console.WriteLine(val);
        }
        public static void Write(string val)
        {
            Console.Write(val);
        }
        public static int ReadInteger()
        {
            return int.Parse(Console.ReadLine());
        }
        public static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }

    }
}
