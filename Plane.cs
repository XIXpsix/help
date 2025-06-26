using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Plane : Vehicle
    {
        public double Height { get; }
        public int Passengers { get; }

        public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Самолёт:");
            Console.WriteLine($"Координаты: ({X}, {Y})");
            Console.WriteLine($"Цена: {Price} BYN");
            Console.WriteLine($"Скорость: {Speed} км/ч");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Высота полёта: {Height} м");
            Console.WriteLine($"Пассажиров: {Passengers}");
            Console.WriteLine();
        }
    }
}
