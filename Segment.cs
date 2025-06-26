using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Segment<T> where T : struct, IComparable<T>
    {
        private T x1, y1, x2, y2;

        public T X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public T Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public T X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public T Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public Segment(T x1, T y1, T x2, T y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public void Show()
        {
            Console.WriteLine($"Отрезок: A({X1}, {Y1}) - B({X2}, {Y2})");
        }

        public double Length()
        {
            dynamic dx = X2, dy = Y2, dx1 = X1, dy1 = Y1;
            return Math.Sqrt(Math.Pow((double)(dx - dx1), 2) + Math.Pow((double)(dy - dy1), 2));
        }
    }
}
