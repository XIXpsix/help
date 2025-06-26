using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Book : Tovar
    {
        private int kvo;

        public Book(string name, decimal price, int kvo) : base(name, price)
        {
            this.kvo = kvo;
        }

        public override void Calc()
        {
            decimal sum = price * kvo;
            Console.WriteLine($"Книга: {name}, Цена: {price}, Количество: {kvo}, Стоимость: {sum}");
        }
    }
}
