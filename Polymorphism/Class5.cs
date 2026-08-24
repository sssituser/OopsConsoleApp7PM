using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Simple
    {
        int num1, num2;
         bool result;
        public void GetNums(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void ShowNums()
        {
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}\t{num1}>{num2}:{num1>num2}");
        }
        public static Simple operator -(Simple P, Simple q)
        {
            Simple res = new Simple();
            res.num1 = P.num1 - q.num1;
            res.num2 = P.num2 - q.num2;
            return res;
           

        }
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================Object-1=============");
            Simple s = new Simple();
            s.GetNums(5, 6);
            s.ShowNums();
            Console.WriteLine("====================Object-2=============");
            Simple s1 = new Simple();
            s1.GetNums(8, 2);
            s1.ShowNums();
            Console.WriteLine("====================Object-2=============");
            Simple s3 = new Simple();
            s3 = s - s1;
            s3.ShowNums();
        }
    }
}
