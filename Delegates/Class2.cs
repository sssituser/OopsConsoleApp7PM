using ClassLibrarySystem;

namespace Delegates
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            LakshmiConsole.Write("Enter an Integr  : ");
            int num = LakshmiConsole.ReadInteger();
            LakshmiConsole.Write("Entter a Double value  : ");
            double d = LakshmiConsole.ReadDouble();
            LakshmiConsole.WriteLine($"num = {num}\td = {d}");
            
        }
    }
}
