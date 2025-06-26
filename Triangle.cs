using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override string ToString()
        {
            return $"Треугольник (a={A}, b={B}, c={C})";
        }
    }
}
