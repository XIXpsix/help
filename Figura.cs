using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Figura
    { // Квадрат
        public void ShowArea(double a)
        {
            double area = a * a;
            Console.WriteLine("Фигура: квадрат");
            Console.WriteLine("Площадь: {0}", area);
        }

        // Прямоугольник
        public void ShowArea(double a, double b)
        {
            double area = a * b;
            Console.WriteLine("Фигура: прямоугольник");
            Console.WriteLine("Площадь: {0}", area);
        }

        // Трапеция
        public void ShowArea(double a, double b, double h)
        {
            double area = ((a + b) / 2) * h;
            Console.WriteLine("Фигура: трапеция");
            Console.WriteLine("Площадь: {0}", area);
        }
    }
}
