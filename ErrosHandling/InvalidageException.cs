using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrosHandling
{
    internal class InvalidageException : Exception
    {
        public InvalidageException() {

            Console.WriteLine("Invalid Age Exception");
        }
        public InvalidageException(string Message) : base(Message) {
        
        
        }
    }
}
