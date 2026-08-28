using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConstructorExamples
{
    class A
    {
       protected int num1, num2 ;
       public void ReadNum(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void ShowNums()
        {
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");
        }
    }
   class B :A
    {
        public void Sum()
        {
            Console.WriteLine($"Sum : {num1+num2}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub : {num1-num2}");
        }
       
    }
    class C : B
    {
      
        public void Mul()
        {
            Console.WriteLine($"Mul : {num1*num2}");
        }
        public void Div()
        {
            Console.WriteLine($"Rem : {num1%num2}");
        }

       
    }
    
    
    internal class Class4
    {
        public static void Main(string[] args)
        {
          C p=new C();
            p.ReadNum(1, 2);
            p.ShowNums();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();
        }
        
    }
}
