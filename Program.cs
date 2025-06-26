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

            var zakazy = new System.Collections.Generic.List<Zakaz>();

            while (true)
            {
                Console.Write("Введите фамилию (или Q для выхода): ");
                string fam = Console.ReadLine();
                if (fam.Equals("Q", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.Write("Введите количество мест в номере: ");
                int size;
                if (!int.TryParse(Console.ReadLine(), out size))
                    size = 1;

                Console.Write("Введите комфортность: ");
                string comfort = Console.ReadLine();

                zakazy.Add(new Zakaz(fam, size, comfort));
            }

            Console.WriteLine("\nСписок заказов:");
            foreach (var z in zakazy)
                z.Show();
        }
    }
}
