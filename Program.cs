using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static double Calculate(double value, ICalculation op1, ICalculation op2)
        {
            double result = op1.Perform(value);
            result = op2.Perform(result);
            return result;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            double number = 10;
            ICalculation add = new Add(5);        // +5
            ICalculation mul = new Multiply(3);   // *3

            double result = Calculate(number, add, mul);
            Console.WriteLine($"((({number} + 5) * 3) = {result})");

            // Можно поменять порядок преобразований
            result = Calculate(number, mul, add);
            Console.WriteLine($"((({number} * 3) + 5) = {result})");
        }
    }
}
