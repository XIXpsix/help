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

            // 1) Создание списка и добавление элементов строчными буквами
            List<string> colors = new List<string> { "красный", "синий", "зелёный", "жёлтый" };

            // 2) Вывод содержимого коллекции
            Console.WriteLine("Список цветов (строчные):");
            PrintList(colors);

            // 3) Преобразование всех элементов в прописные
            for (int i = 0; i < colors.Count; i++)
                colors[i] = colors[i].ToUpper();

            // 4) Вывод содержимого коллекции
            Console.WriteLine("Список цветов (прописные):");
            PrintList(colors);

            // 5) Определение количества элементов
            Console.WriteLine($"Количество элементов: {colors.Count}");

            // 6) Добавление нового элемента в конец
            colors.Add("ФИОЛЕТОВЫЙ");

            // 7) Вывод содержимого коллекции
            Console.WriteLine("После добавления в конец:");
            PrintList(colors);

            // 8) Добавление нового элемента в начало
            colors.Insert(0, "БЕЛЫЙ");

            // 9) Вывод содержимого коллекции
            Console.WriteLine("После добавления в начало:");
            PrintList(colors);

            // 10) Удаление третьего элемента (индекс 2)
            if (colors.Count > 2)
                colors.RemoveAt(2);

            // 11) Вывод содержимого коллекции
            Console.WriteLine("После удаления третьего элемента:");
            PrintList(colors);

            // 12) Разворот списка
            colors.Reverse();
            Console.WriteLine("После разворота:");
            PrintList(colors);
        }

        static void PrintList(List<string> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
