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

            while (true)
            {
                Console.Write("Enter document format: ");
                string format = Console.ReadLine().Trim().ToUpper();

                if (format == "QUIT")
                    break;

                AbstractHandler handler = null;
                switch (format)
                {
                    case "DOC":
                        handler = new DOCHandler();
                        break;
                    case "XML":
                        handler = new XMLHandler();
                        break;
                    case "TXT":
                        handler = new TXTHandler();
                        break;
                    default:
                        Console.WriteLine("Failed format! Enter again!");
                        continue;
                }

                handler.Open();
                handler.Create();
                handler.Chenge();
                handler.Save();
            }
        }
    }
}
