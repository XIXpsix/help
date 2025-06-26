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
            Point a = new Point(0, 0, "A");
            Point b = new Point(4, 0, "B");
            Point c = new Point(4, 3, "C");
            Figure triangle = new Figure(a, b, c);
            triangle.PerimeterCalculator();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
