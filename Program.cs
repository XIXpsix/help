using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{    // б) объявить тип делегата

    public delegate int SumDelegate(int m, int n);

    internal class Program
    {        // а) статический метод для вычисления суммы

        public static int Sum(int m, int n)
        {
            if (m > n)
                throw new ArgumentException("m должно быть меньше или равно n");
            int sum = 0;
            for (int i = m; i <= n; i++)
                sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // в) объявление делегата
            SumDelegate sumDel = Sum;

            // г) применение делегата 3 раза
            Console.WriteLine("Сумма от 1 до 10: {0}", sumDel(1, 10));
            Console.WriteLine("Сумма от 5 до 15: {0}", sumDel(5, 15));
            Console.WriteLine("Сумма от 100 до 105: {0}", sumDel(100, 105));
        }
    }
}
