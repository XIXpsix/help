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

            Book[] books = new Book[]
            {
                new Book("Программирование на языке высокого уровня", "Павловская И.А. С.Н.", 2013, 430),
                new Book("Полный справочник по C# 4.0", "Герберт Шилдт", 2010, 900),
                new Book("Понятно о Visual Basic.Net. Самоучитель. В трёх томах", "Лукин С.Н.", 2005, 800),
                new Book("Практикум по Visual Basic 2007", "Усеева О.П.", 2007, 544)
            };

            foreach (var book in books)
            {
                book.Show();
            }
        }
    }
}
