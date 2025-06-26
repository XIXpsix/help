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

            Point<int> p1 = new Point<int>(3, 5);
            Point<uint> p2 = new Point<uint>(10u, 20u);
            Point<double> p3 = new Point<double>(1.5, 2.7);

            p1.Show();
            p2.Show();
            p3.Show();
        }
    }
}
