using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{       
    public delegate double TriangleAreaDelegate(double a, double b, double c);

    internal class Program
    {
        // 1. Статический метод для вычисления площади треугольника по формуле Герона
        public static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // 2-3. Объявление и создание делегата
            TriangleAreaDelegate areaDel = S;

            // 4. Применение делегата 3 раза
            Console.WriteLine("Площадь треугольника (3, 4, 5): {0}", areaDel(3, 4, 5));
            Console.WriteLine("Площадь треугольника (5, 5, 8): {0}", areaDel(5, 5, 8));
            Console.WriteLine("Площадь треугольника (7, 10, 5): {0}", areaDel(7, 10, 5));
        }
    }
}
