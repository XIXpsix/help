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
            const string proKey = "pro";
            const string expKey = "exp";

            Console.WriteLine("Введите ключ доступа (pro/exp), либо нажмите Enter для бесплатной версии:");
            string key = Console.ReadLine();

            DocumentWorker worker;

            if (key == expKey)
            {
                worker = new ExpertDocumentWorker();
            }
            else if (key == proKey)
            {
                worker = new ProDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
