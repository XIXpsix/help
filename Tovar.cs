using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Tovar
    {
        protected string name;
        protected decimal price;

        public Tovar(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual void Calc()
        {
            Console.WriteLine($"Товар: {name}, Цена: {price}");
        }
    }
}
