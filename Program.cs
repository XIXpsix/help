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
            MyClass obj = new MyClass();

            Console.WriteLine("Вызов метода, возвращающего число типа int: {0}", obj.GetInt());
            Console.WriteLine("Вызов метода, возвращающего число Pi: {0}", obj.GetPi());
            Console.WriteLine("Вызов метода, возвращающего x в квадрате: {0}", obj.Square(3));
            Console.WriteLine("Вызов метода, возвращающего корень квадратный из x: {0}", obj.Sqrt(6.25));

            Console.WriteLine("Вызов метода, возвращающего число типа int: {0}", obj.GetInt());
        }
    }
}
