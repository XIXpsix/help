using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Ship : Vehicle
    {
        private int passengers;
        private string port;

        public Ship(double x, double y, double z, decimal price, int speed, int year, int passengers, string port)
            : base(x, y, z, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($", Количество пассажиров: {passengers}, Порт приписки: {port}");
        }
    }
}
