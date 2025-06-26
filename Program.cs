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
            Console.Write("Введите длину первой стороны прямоугольника: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Введите длину второй стороны прямоугольника: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(side1, side2);

            Console.WriteLine($"Площадь прямоугольника: {rect.Area}");
            Console.WriteLine($"Периметр прямоугольника: {rect.Perimeter}");

            Console.ReadKey();
        }
    }
}
