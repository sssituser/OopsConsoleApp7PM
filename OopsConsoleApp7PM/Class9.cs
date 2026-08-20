using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Class9
    {
        public static void Main()
        {
            Movie m = new Movie() { MovieId=11,MovieName="abc",MovieRating=4.7};
           
            Console.WriteLine(m.MovieId);
            Console.WriteLine(m.MovieName);
            Console.WriteLine(m.MovieRating);

            Movie m2 = new Movie() { MovieId=123,MovieName="def",MovieRating=4.3};
            Console.WriteLine(m2.MovieId);
            Console.WriteLine(m2.MovieName);
            Console.WriteLine(m2.MovieRating);
            
           
            
        }
    }
}
