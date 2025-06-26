using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Product
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int ShelfLife { get; set; } // срок хранения в днях
        public int Quantity { get; set; }

        public Product(string name, string manufacturer, decimal price, int shelfLife, int quantity)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ShelfLife = shelfLife;
            Quantity = quantity;
        }

        public void Show()
        {
            Console.WriteLine($"Наименование: {Name}, Производитель: {Manufacturer}, Цена: {Price}, Срок хранения: {ShelfLife} дн., Количество: {Quantity}");
        }
    }
}
