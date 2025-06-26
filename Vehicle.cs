using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Vehicle
    {
        protected double X { get; }
        protected double Y { get; }
        protected double Price { get; }
        protected double Speed { get; }
        protected int Year { get; }
        public Vehicle(double x, double y, double price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Транспортное средство:");
            Console.WriteLine($"Координаты: ({X}, {Y})");
            Console.WriteLine($"Цена: {Price} BYN");
            Console.WriteLine($"Скорость: {Speed} км/ч");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine();
        }
    }
}
