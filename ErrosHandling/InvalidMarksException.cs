using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrosHandling
{
    internal class InvalidMarksException:Exception
    {
       
        public InvalidMarksException()
        {
            Console.WriteLine(":Invalid Marks ");
        }
        public InvalidMarksException(string message) : base(message)
        {

        }
       
        public override string ToString()
        {
            return GetType().Namespace+"."+GetType().Name+" :  Invalid Marks";
        }
    }
}
