using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void DelegateClass(int a, int b);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DelegateClass d1 = new DelegateClass(new Test().Sum);
            DelegateClass d2 = new DelegateClass(new Test().Sub);
            DelegateClass d3 = new DelegateClass(Test.Mul);
            DelegateClass d4 = new DelegateClass(Test.Div);
            DelegateClass d5 = d1 + d2 + d3 + d4;
            d5(5, 2);

            DelegateClass d6 = d1 + d2;
            d6(10, 2);



        }
    }
}
