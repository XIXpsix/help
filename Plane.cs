using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Plane : Vehicle
    {
        private int height;
        private int passengers;

        public Plane(double x, double y, double z, decimal price, int speed, int year, int height, int passengers)
            : base(x, y, z, price, speed, year)
        {
            this.height = height;
            this.passengers = passengers;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", Высота: {height}, Количество пассажиров: {passengers}");
        }
    }
}
