using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsSystem
{
    public class Numbers
    {
        public bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }

        public int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
           
        }
        public bool IsAdam(int num)
        {
            return Square(num)==    Reverse(Square(Reverse(num)));
        }

        public int Square(int num)
        {
            return num * num;
        }
    }
}
