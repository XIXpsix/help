using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Posuda : Tovar
    {
        public double Mass { get; set; }
        public string Color { get; set; }

        public Posuda(string name, decimal price, double mass, string color)
            : base(name, price)
        {
            Mass = mass;
            Color = color;
        }

        public override decimal CalcSum()
        {
            return Price * (decimal)Mass;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Масса: {Mass} кг, Цвет: {Color}, Стоимость: {CalcSum()}");
        }
    }
}
