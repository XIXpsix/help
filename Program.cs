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
                new Book("C# для начинающих", 15, 2),
                new Pen("Parker", 5, 3),
                new Candy("Мишка на севере", 12, 1.5)
            };

            foreach (var t in tovary)
                t.Calc();
        }
    }
}
