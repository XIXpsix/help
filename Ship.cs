using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Ship : Vehicle
    {
        public int Passengers { get; }
        public string Port { get; }

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Корабль:");
            Console.WriteLine($"Координаты: ({X}, {Y})");
            Console.WriteLine($"Цена: {Price} BYN");
            Console.WriteLine($"Скорость: {Speed} км/ч");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Пассажиров: {Passengers}");
            Console.WriteLine($"Порт приписки: {Port}");
            Console.WriteLine();
        }
    }
}
