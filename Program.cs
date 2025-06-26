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
            // Пример курсов: 1 USD = 3.2 BYN, 1 EUR = 3.5 BYN, 1 RUB = 0.034 BYN
            Converter converter = new Converter(3.2, 3.5, 0.034);

            Console.WriteLine("Введите сумму в BYN:");
            double byn = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"BYN -> USD: {converter.FromBYNToUSD(byn):F2}");
            Console.WriteLine($"BYN -> EUR: {converter.FromBYNToEUR(byn):F2}");
            Console.WriteLine($"BYN -> RUB: {converter.FromBYNToRUB(byn):F2}");

            Console.WriteLine("\nВведите сумму в USD:");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"USD -> BYN: {converter.FromUSDToBYN(usd):F2}");

            Console.WriteLine("\nВведите сумму в EUR:");
            double eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"EUR -> BYN: {converter.FromEURToBYN(eur):F2}");

            Console.WriteLine("\nВведите сумму в RUB:");
            double rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"RUB -> BYN: {converter.FromRUBToBYN(rub):F2}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
