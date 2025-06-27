using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public abstract class Vehicle
    {
        protected double x, y, z;
        protected decimal price;
        protected int speed;
        protected int year;

        public Vehicle(double x, double y, double z, decimal price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void Show()
        {
            Console.Write($"Координаты: ({x},{y},{z}), Цена: {price}, Скорость: {speed}, Год выпуска: {year}");
        }
    }
}
