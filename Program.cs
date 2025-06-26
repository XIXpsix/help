using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    // 2. Объявление типа делегата
    public delegate double AverageDelegate(int m, int n);

    internal class Program
    {
        // 1. Статический метод для вычисления среднего арифметического
        public static double Average(int m, int n)
        {
            if (m > n)
                throw new ArgumentException("m должно быть меньше или равно n");

            int sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // 3. Объявление делегата
            AverageDelegate avgDel = Average;

            // 4. Применение делегата 3 раза
            Console.WriteLine("Среднее от 1 до 10: {0}", avgDel(1, 10));
            Console.WriteLine("Среднее от 5 до 15: {0}", avgDel(5, 15));
            Console.WriteLine("Среднее от 100 до 105: {0}", avgDel(100, 105));
        }
    }
}
