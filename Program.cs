using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("***Exploring Interfaces.Example-5***");
            Console.WriteLine("***Concept of multiple inheritance through  interface***\n");

            MyClass myClassOb = new MyClass();
            myClassOb.ShowInterfaceA();
            myClassOb.ShowInterfaceB();
            myClassOb.ShowInterfaceC();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
