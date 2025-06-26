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
            Console.InputEncoding = System.Text.Encoding.UTF8;// Пример данных
            int account = 12345;
            string customer = "ООО Ромашка";
            string provider = "ЗАО Поставщик";
            string article = "Монитор";
            int quantity = 3;
            double pricePerItem = 500.0;

            Invoice invoice = new Invoice(account, customer, provider, article, quantity);

            Console.WriteLine("Введите 1 для расчёта суммы без НДС, 2 — с НДС:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                double total = invoice.GetTotalWithoutVAT(pricePerItem);
                Console.WriteLine($"Сумма к оплате без НДС: {total:F2} BYN");
            }
            else if (choice == "2")
            {
                double total = invoice.GetTotalWithVAT(pricePerItem);
                Console.WriteLine($"Сумма к оплате с НДС (20%): {total:F2} BYN");
            }
            else
            {
                Console.WriteLine("Некорректный выбор.");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
