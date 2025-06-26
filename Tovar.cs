using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Tovar
    {
        private string name;
        private decimal price;
        private int kvo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 1) price = 1;
                else if (value > 20) price = 20;
                else price = value;
            }
        }

        public int Kvo
        {
            get { return kvo; }
            set
            {
                if (value < 0) kvo = 0;
                else if (value > 10) kvo = 10;
                else kvo = value;
            }
        }

        public Tovar(string name, decimal price, int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }

        public decimal TotalCost()
        {
            return Price * Kvo;
        }

        public void Show()
        {
            Console.WriteLine($"Товар: {Name}, Цена: {Price}, Количество: {Kvo}, Стоимость: {TotalCost()}");
        }
    }
}
