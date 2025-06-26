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
            Console.WriteLine("Введите формат документа (xml, txt, doc):");
            string format = Console.ReadLine();

            AbstractHandler handler = null;

            switch (format.ToLower())
            {
                case "xml":
                    handler = new XMLHandler();
                    break;
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "doc":
                    handler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Неизвестный формат документа.");
                    return;
            }

            handler.Open();
            handler.Create();
            handler.Chenge();
            handler.Save();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
