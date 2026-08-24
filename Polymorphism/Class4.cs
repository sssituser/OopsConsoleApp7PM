using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Sample
    {
        int a, b;
        public void ReadNums()
        {
            Console.Write("Enter number-1 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter number-2 : ");
            b = int.Parse(Console.ReadLine());
        }
        public void ShowNums()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public static Sample operator+(Sample firstObject,Sample secondObject)
        {
            Sample res = new Sample();
            res.a = firstObject.a + secondObject.a;
            res.b = firstObject.b + secondObject.b;
            return res;
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Object-1====================");
            Sample s1 = new Sample();
            s1.ReadNums();
            s1.ShowNums();

            Console.WriteLine("===============Object-2====================");
            Sample s2 = new Sample();
            s2.ReadNums();
            s2.ShowNums();

            Console.WriteLine("===============Object-3====================");
            Sample s3 = new Sample();
            s3 = s1 + s2;
            s3.ShowNums();
        }
    }
}
