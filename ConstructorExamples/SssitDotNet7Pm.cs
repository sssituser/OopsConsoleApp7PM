using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorExamples
{
    internal class SssitDotNet7Pm
    {
       static int amount = 20000; // non static or Instance(object) variables

        public void Spent(int spamount)
        {
            Console.WriteLine($"Used Amount is : {spamount}");
            amount = amount - spamount;
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Balance is : {amount}");
        }
    }
}
