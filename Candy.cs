using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Candy : Tovar
    {
        private double ves; // вес в кг

        public Candy(string name, decimal price, double ves) : base(name, price)
        {
            this.ves = ves;
        }

        public override void Calc()
        {
            decimal sum = price * (decimal)ves;
            Console.WriteLine($"Конфеты: {name}, Цена за кг: {price}, Вес: {ves} кг, Стоимость: {sum}");
        }
    }
}
