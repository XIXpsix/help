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

            var agencies = new List<TravelAgency>
            {
                new TravelAgency("Вояж", 2001, "1234567890", 500000),
                new TravelAgency("Путешественник", 1998, "2345678901", 350000),
                new TravelAgency("МирТур", 2010, "3456789012", 800000),
                new TravelAgency("Солнышко", 2015, "4567890123", 0) // обанкротившаяся фирма
            };

            // 3. Для заданной фирмы найти ИНН и прибыль
            Console.WriteLine("Введите название фирмы для поиска:");
            string searchName = Console.ReadLine();
            var found = agencies.Find(a => a.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (found != null)
                Console.WriteLine($"ИНН: {found.INN}, Прибыль: {found.Profit} руб.");
            else
                Console.WriteLine("Фирма не найдена.");

            // 4. Суммарная прибыль всех фирм
            decimal totalProfit = 0;
            foreach (var agency in agencies)
                totalProfit += agency.Profit;
            Console.WriteLine($"Суммарная прибыль всех фирм: {totalProfit} руб.");

            // 5. Фирма с наибольшей прибылью
            TravelAgency maxProfitAgency = null;
            decimal maxProfit = decimal.MinValue;
            foreach (var agency in agencies)
            {
                if (agency.Profit > maxProfit)
                {
                    maxProfit = agency.Profit;
                    maxProfitAgency = agency;
                }
            }
            if (maxProfitAgency != null)
                Console.WriteLine($"Наибольшая прибыль у фирмы: {maxProfitAgency.Name}, прибыль: {maxProfitAgency.Profit} руб.");

            // 6. Удалить обанкротившуюся фирму (прибыль = 0)
            agencies.RemoveAll(a => a.Profit == 0);

            // 7. Добавить новую фирму
            agencies.Add(new TravelAgency("Горизонт", 2023, "5678901234", 120000));

            // Вывод всех фирм
            Console.WriteLine("\nАктуальный список фирм:");
            foreach (var agency in agencies)
                agency.ShowInfo();
        }
    }
}
