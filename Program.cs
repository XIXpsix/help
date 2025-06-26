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

            Vehicle plane = new Plane(10, 20, 5000000, 900, 2018, 12000, 180);
            Vehicle car = new Car(5, 15, 35000, 220, 2021);
            Vehicle ship = new Ship(0, 0, 20000000, 60, 2015, 500, "Одесса");

            plane.ShowInfo();
            car.ShowInfo();
            ship.ShowInfo();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
