using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        protected int num1, num2;
        public void ReadNums()
        {
            Console.Write("Enter num1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            num2 = int.Parse(Console.ReadLine());
        }
        public void GetNums()
        {
            Console.WriteLine($"num1 = {num1}\tnum = {num2}");
        }
    }
    interface IB
    {
        void Sum();
        void Sub();
    }
    interface IC
    {
        void Mul();
        void Div();
    }
    class D : A, IB, IC // This line is Responsible for multiple inheritance
    {
        public void Div()
        {

            Console.WriteLine($"Quo : {num1 / num2}");
        }

        public void Mul()
        {
            Console.WriteLine($"Mul : {num1 * num2}");
        }

        public void Sub()
        {
            Console.WriteLine($"Sub : {num1 - num2}");
        }

        public void Sum()
        {
            Console.WriteLine($"Sum : {num1 + num2}");
        }
        public void Rem()
        {
            Console.WriteLine($"Rem : {num1 % num2}");
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            D p = new D();
            p.ReadNums();
            p.GetNums();
            p.Sum();
            p.Mul();
            p.Sub();
            p.Div();
            p.Rem();
        }
    }
}
