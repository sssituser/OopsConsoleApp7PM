using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySystem;
namespace Delegates
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Lakshmi.Mul(5, 2);
            Lakshmi.Div(5, 2);
            Lakshmi l = new Lakshmi();
            l.Sub(5, 2);
            l.Add(5, 2);
        }
    }
}
