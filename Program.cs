using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static void PrintShapeInfo(IShape shape)
        {
            Console.WriteLine(shape.ToString());
            Console.WriteLine($"Периметр: {shape.Perimeter()}");
            Console.WriteLine($"Площадь: {shape.Area()}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            IShape t = new Triangle(3, 4, 5);
            IShape d = new Disk(2.5);

            PrintShapeInfo(t);
            PrintShapeInfo(d);
        }
    }
}
