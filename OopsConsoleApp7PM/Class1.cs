using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class1
    {/*Write a program to perform Arithmetic opeations for the
      * given 2 numbers num1 = 5  num2 = 2    sum,sub,mul,div
      */
        public static int AriOperations( int num1,  int num2,out int sum,out int sub,out int mul)
        {
            sum = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            return num1 / num2;
        }
        public static void Main()
        {
            Console.WriteLine($"quo : {AriOperations(5,2,out int x,out int y,out int z)},sum : {x}, sub :{y},mul : {z}");
        }
    }
}
