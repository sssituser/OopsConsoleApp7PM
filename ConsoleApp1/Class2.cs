using SuhanaSystem;
using System.Data;
namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            SuhanaConsole.Print("Enter an Integer : ");
            int a = SuhanaConsole.ReadInt();
            SuhanaConsole.Print("Enter a Double : ");
            double b = SuhanaConsole.ReadDouble();
            SuhanaConsole.PrintLine($"a = {a}\tb = {b}");

        }
    }
}
