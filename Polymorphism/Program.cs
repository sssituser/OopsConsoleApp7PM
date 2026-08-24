using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mover m = new Mover();
            m.Add(5, 2);
            m.Add(3, 4);
            m.Add(5.8, 1.6);
            m.Add("kiran", "kumar");
        }
    }
}
