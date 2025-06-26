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

            Product[] products = new Product[]
            {
                new Product("Молоко", "Савушкин", 2.5m, 7, 20),
                new Product("Молоко", "Простоквашино", 2.7m, 10, 15),
                new Product("Хлеб", "Дарница", 1.2m, 3, 30),
                new Product("Сыр", "Беллакт", 5.5m, 30, 10),
                new Product("Молоко", "Брест-Литовск", 2.3m, 5, 25)
            };

            Console.Write("Введите наименование товара: ");
            string searchName = Console.ReadLine();

            Console.WriteLine("\nа) Список товаров для заданного наименования:");
            foreach (var p in products)
                if (p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    p.Show();

            Console.Write("\nВведите максимальную цену: ");
            decimal maxPrice;
            decimal.TryParse(Console.ReadLine(), out maxPrice);

            Console.WriteLine($"\nб) Список товаров для \"{searchName}\" с ценой не выше {maxPrice}:");
            foreach (var p in products)
                if (p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase) && p.Price <= maxPrice)
                    p.Show();

            Console.Write("\nВведите минимальный срок хранения (дней): ");
            int minShelfLife;
            int.TryParse(Console.ReadLine(), out minShelfLife);

            Console.WriteLine($"\nв) Список товаров с сроком хранения больше {minShelfLife} дней:");
            foreach (var p in products)
                if (p.ShelfLife > minShelfLife)
                    p.Show();
        }
    }
}
