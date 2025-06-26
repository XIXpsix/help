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

            Figura figura = new Figura();

            figura.ShowArea(4);           // квадрат
            figura.ShowArea(3, 5);        // прямоугольник
            figura.ShowArea(2, 4, 3);     // трапеция
        }
    }
}
