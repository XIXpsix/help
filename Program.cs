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

            var s1 = new Segment<int>(0, 0, 3, 4);
            var s2 = new Segment<long>(10, 20, 13, 24);
            var s3 = new Segment<double>(1.5, 2.5, 4.5, 6.5);

            s1.Show();
            Console.WriteLine($"Длина: {s1.Length()}\n");

            s2.Show();
            Console.WriteLine($"Длина: {s2.Length()}\n");

            s3.Show();
            Console.WriteLine($"Длина: {s3.Length()}\n");
        }
    }
}
