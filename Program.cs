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

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            Console.WriteLine("Доступные цвета:");
            foreach (var value in Enum.GetValues(typeof(MyColor)))
            {
                Console.WriteLine($"{(int)value}. {value}");
            }

            Console.Write("Введите номер цвета: ");
            int colorNum;
            int.TryParse(Console.ReadLine(), out colorNum);

            Printer.Print(input, colorNum);
        }
    }
}
