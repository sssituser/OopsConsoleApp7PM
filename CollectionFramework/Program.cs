using System;
using System.Collections;


namespace CollectionFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {

        

            Stack s = new Stack();  // Last In First Out
            s.Push(18);
            s.Push("Lakshmi");
            s.Push(6.7);
            s.Push(true);
            s.Push('+');
            Console.WriteLine($"No Of elements present in the stack is :{s.Count}");
            object r = s.Clone();
            foreach(object ob in r as Stack)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("************************");
            foreach(object ob in s)
            {
                Console.WriteLine(ob);
            }
           
            Console.WriteLine($"Top or Last Inserted Element in the Stack : {s.Peek()}");
            Console.WriteLine($"Deleted Element is : {s.Pop()}");
            Console.WriteLine("==============Elements After deleting the element from the Stack are====");
            foreach (object ob in s)
            {
                Console.WriteLine(ob);
            }

           

        }
    }
}
