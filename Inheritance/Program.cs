using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SciCalcy s = new SciCalcy();
            s.Sum(5, 2);
            s.Sub(5, 2);
            s.Mul(5,2);
            s.Sine(90);
            s.Cosi(0);
        }
    }
}
