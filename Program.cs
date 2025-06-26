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

            Tovar[] tovary = new Tovar[]
            {
                new Obuv("Ботинки", 120, 2, 42, "черный"),
                new Odejda("Пальто", 200, 1, "L", "синий"),
                new Posuda("Кастрюля", 80, 1.5, "серебристый")
            };

            foreach (var t in tovary)
            {
                t.Print();
                Console.WriteLine();
            }
        }
    }
}
