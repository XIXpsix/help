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
            Printer basePrinter = new Printer();
            Printer redPrinter = new RedPrinter();
            Printer greenPrinter = new GreenPrinter();

            // Используем приведение типов
            ((Printer)redPrinter).Print("Текст красным цветом");
            ((Printer)greenPrinter).Print("Текст зелёным цветом");
            basePrinter.Print("Текст обычным цветом");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
