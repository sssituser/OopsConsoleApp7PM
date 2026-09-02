using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    abstract class Testt
    {
        protected int a, b;
        public void ReadNums()
        {
            Console.Write("Enter a number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b number : ");
            b = int.Parse(Console.ReadLine());
        }
        public void ShowNums()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public abstract void Sum();
        public abstract void Sub();
    }
    class AbsImplement : Testt
    {
        public override void Sub()
        {
            Console.WriteLine($"Sub : {a-b}");
        }

        public override void Sum()
        {
            Console.WriteLine($"Sum : {a+b}");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul is :{a*b}");
        }
        public void Div()
        {
            Console.WriteLine($"Quo : {a/b}");
        }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            AbsImplement p = new AbsImplement();
            p.ReadNums();
            p.ShowNums();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();
        }
    }
}
