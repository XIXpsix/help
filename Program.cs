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

            Vehicle[] vehicles = new Vehicle[]
            {
                new Plane(55, 75, 37, 1000000, 800, 2020, 10000, 200),
                new Car(55, 75, 37, 20000, 180, 2015, 5),
                new Ship(55, 75, 37, 500000, 30, 2010, 500, "Санкт-Петербург")
            };

            foreach (var v in vehicles)
                v.Show();
        }
    }
}
