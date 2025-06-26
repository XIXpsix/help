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

            var t1 = new Triangle<int>(3, 4, 5);
            var t2 = new Triangle<uint>(6u, 7u, 8u);
            var t3 = new Triangle<double>(2.5, 3.5, 4.5);

            t1.Show();
            Console.WriteLine($"Площадь: {t1.Area()}\n");

            t2.Show();
            Console.WriteLine($"Площадь: {t2.Area()}\n");

            t3.Show();
            Console.WriteLine($"Площадь: {t3.Area()}\n");
        }
    }
}
