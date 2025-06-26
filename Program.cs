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

            Point p1 = new Point(2, 3);
            Point p2 = new Point(-1, 4);
            Point p3 = new Point(-2, -5);
            Point p4 = new Point(3, -2);
            Point p5 = new Point(0, 0);

            p1.Show();
            p2.Show();
            p3.Show();
            p4.Show();
            p5.Show();

            Console.WriteLine("\nСтатистика по четвертям:");
            Point.ShowStats();
        }
    }
}
