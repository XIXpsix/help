using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Odejda : Tovar
    {
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        public Odejda(string name, decimal price, int quantity, string size, string color)
            : base(name, price)
        {
            Quantity = quantity;
            Size = size;
            Color = color;
        }

        public override decimal CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество: {Quantity}, Размер: {Size}, Цвет: {Color}, Стоимость: {CalcSum()}");
        }
    }
}
