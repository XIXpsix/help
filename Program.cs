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

            Computer[] computers = new Computer[]
            {
                new Computer("HP Pavilion", 8, 500, 25000),
                new Computer("Acer Aspire", 16, 1000, 35000),
                new Computer("Lenovo ThinkPad", 32, 2000, 50000),
                new Computer("Dell Inspiron", 1, 100, 15000) // ограничения сработают
            };

            decimal total = 0;
            foreach (var comp in computers)
            {
                comp.Show();
                total += comp.Price;
            }
            Console.WriteLine($"Общая стоимость всех моделей: {total} руб.");
        }
    }
}
