using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{

    internal class Class1
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            object ob;
        Menu:
            Console.Write("1.Add\n2.Delete\n3.Disply\n4.Check\n5.Top\n6.Elements Count\nEnter Your choice : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            
            switch (choice)
            {
                case 1:
                    Console.Write("Enter an Element to Add : ");
                    ob = Console.ReadLine();
                    st.Push(ob);
                    goto Menu;
                case 2:
                    if(st.Count== 0)
                    {
                        Console.WriteLine($"No Elements to delete");
                    }
                    else
                    {
                        Console.WriteLine($"Deleted Element is : {st.Pop()}");
                    }
                    goto Menu;
                case 3:
                    if (st.Count == 0)
                    {
                        Console.WriteLine("No Elements Found");
                    }
                    else
                    {
                        foreach (var item in st)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    goto Menu;
                case 4:
                    Console.Write("Enter element : ");
                     ob = Console.ReadLine();
                    if (st.Contains(ob))
                    {
                        Console.WriteLine($"{ob} Element Exists");
                    }
                    else
                    {
                        Console.WriteLine($"{ob} Element Not Exists");
                    }
                    goto Menu;
                case 5:
                    if (st.Count == 0)
                    {
                        Console.WriteLine($"No Elements to display");
                    }
                    else
                    {
                        Console.WriteLine($"Top Element in the Stack is : {st.Peek()}");
                    }
                        goto Menu;
                case 6:
                    Console.WriteLine($"Total Elements in the Stack are :{st.Count}");
                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice...");
                    goto Menu;
            }
        }
    }
}
