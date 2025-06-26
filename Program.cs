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

            // Создание объектов с разными конструкторами
            Kupyura k1 = new Kupyura();
            Kupyura k2 = new Kupyura("Доллар", 100, 5);
            Kupyura k3 = new Kupyura("Евро");

            // Задание значений свойствам
            k1.Name = "Рубль";
            k1.Nominal = 50;
            k1.Count = 10;

            k3.Nominal = 200;
            k3.Count = 2;

            // Вывод значений
            k1.Show();
            k2.Show();
            k3.Show();

            // Демонстрация методов
            Console.WriteLine("\nИзменение количества купюр:");
            k1.ChangeCount(-3);
            k1.Show();

            Console.WriteLine("\nПроверка оплаты (стоимость 400):");
            Console.WriteLine(k1.EnoughFor(400) ? "Достаточно для оплаты." : "Недостаточно для оплаты.");
            Console.WriteLine(k2.EnoughFor(600) ? "Достаточно для оплаты." : "Недостаточно для оплаты.");
        }
    }
}
