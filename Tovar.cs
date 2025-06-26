using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Tovar
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Tovar(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract decimal CalcSum();

        public virtual void Print()
        {
            Console.WriteLine($"Название: {Name}, Цена: {Price}");
        }
    }
}
