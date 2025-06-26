using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Point
    {
        private double x, y;

        // Статические поля для подсчёта точек в четвертях и всего
        private static int countQ1 = 0;
        private static int countQ2 = 0;
        private static int countQ3 = 0;
        private static int countQ4 = 0;
        private static int totalCount = 0;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            totalCount++;
            if (x > 0 && y > 0) countQ1++;
            else if (x < 0 && y > 0) countQ2++;
            else if (x < 0 && y < 0) countQ3++;
            else if (x > 0 && y < 0) countQ4++;
        }

        public void Show()
        {
            Console.WriteLine($"Точка: ({x}, {y})");
        }

        public static void ShowStats()
        {
            Console.WriteLine($"1-я четверть: {countQ1}");
            Console.WriteLine($"2-я четверть: {countQ2}");
            Console.WriteLine($"3-я четверть: {countQ3}");
            Console.WriteLine($"4-я четверть: {countQ4}");
            Console.WriteLine($"Всего точек: {totalCount}");
        }
    }
}
