using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Triangle<T> where T : struct, IComparable<T>
    {
        private T a;
        private T b;
        private T c;

        public T A
        {
            get { return a; }
            set
            {
                if (IsPositive(value)) a = value;
                else throw new ArgumentException("Сторона должна быть положительной");
            }
        }

        public T B
        {
            get { return b; }
            set
            {
                if (IsPositive(value)) b = value;
                else throw new ArgumentException("Сторона должна быть положительной");
            }
        }

        public T C
        {
            get { return c; }
            set
            {
                if (IsPositive(value)) c = value;
                else throw new ArgumentException("Сторона должна быть положительной");
            }
        }

        public Triangle(T a, T b, T c)
        {
            if (!IsTriangle(a, b, c))
                throw new ArgumentException("Стороны не образуют треугольник");
            A = a;
            B = b;
            C = c;
        }

        private bool IsPositive(T value)
        {
            return Comparer<T>.Default.Compare(value, default(T)) > 0;
        }

        private bool IsTriangle(T a, T b, T c)
        {
            dynamic da = a, db = b, dc = c;
            return da + db > dc && da + dc > db && db + dc > da;
        }

        public void Show()
        {
            Console.WriteLine($"Треугольник со сторонами: a = {A}, b = {B}, c = {C}");
        }

        public double Area()
        {
            dynamic da = A, db = B, dc = C;
            double p = (da + db + dc) / 2.0;
            return Math.Sqrt(p * (p - da) * (p - db) * (p - dc));
        }
    }
}
