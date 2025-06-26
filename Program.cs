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
                new Tovar("Яблоки", 5, 3),
                new Tovar("Груши", 25, 2), // цена будет ограничена 20
                new Tovar("Бананы", 2, 12), // количество будет ограничено 10
                new Tovar("Апельсины", 0, -1) // цена будет 1, количество 0
            };

            decimal total = 0;
            foreach (var t in tovary)
            {
                t.Show();
                total += t.TotalCost();
            }
            Console.WriteLine($"Общая стоимость заказа: {total}");
        }
    }
}
