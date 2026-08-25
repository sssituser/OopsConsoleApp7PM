using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Tesla
    {
        public virtual void Show()
        {
            Console.WriteLine("Hi Iam Show Method from Tesla class");
        }
        public void Dispaly()
        {
            Console.WriteLine("Hi Iam Display Method from Tesla class");
        }
    }

    class Tech : Tesla
    {
        public void Hi()
        {
            Console.WriteLine("Hi Iam Hi metho from Tech class");
        }
        public void Bye()
        {
            Console.WriteLine("Hi I am Bye Method From Tech class");
        }
        public override void Show()
        {
            Console.WriteLine("Hi iam Show Method from Tech class");
        }
    }
    internal class Class6
    {
        static void Main(string[] args)
        {
            Tech t = new Tech();
            t.Dispaly();
            t.ToString();
        }
    }
}
