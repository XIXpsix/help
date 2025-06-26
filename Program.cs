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

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            DateClass date = new DateClass(year, month, day);
            date.Show();
            Console.WriteLine($"Предыдущий день: {date.PreviousDay().ToShortDateString()}");
            Console.WriteLine($"Следующий день: {date.NextDay().ToShortDateString()}");
        }
    }
}
