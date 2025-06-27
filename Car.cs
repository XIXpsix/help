using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Car : Vehicle
    {
        private int passengers;

        public Car(double x, double y, double z, decimal price, int speed, int year, int passengers)
            : base(x, y, z, price, speed, year)
        {
            this.passengers = passengers;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", Количество пассажиров: {passengers}");
        }
    }
}
