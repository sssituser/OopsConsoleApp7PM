using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenerics
{
    internal class Test<T>
    {
        public void Show(T x)
        {
            Console.WriteLine($"x = {x}");
        }

    }
}
