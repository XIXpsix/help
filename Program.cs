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

            try
            {
                Console.Write("Введите первое число: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию: +  -  *  /");
                string op = Console.ReadLine();

                double result = 0;
                switch (op)
                {
                    case "+":
                        result = Calculator.Add(a, b);
                        break;
                    case "-":
                        result = Calculator.Sub(a, b);
                        break;
                    case "*":
                        result = Calculator.Mul(a, b);
                        break;
                    case "/":
                        result = Calculator.Div(a, b);
                        break;
                    default:
                        throw new InvalidOperationException("Неизвестная операция!");
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
