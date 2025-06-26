using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Notebook
    {
        public string Model;
        public string Manufacturer;
        public decimal Price;

        public Notebook(string model, string manufacturer, decimal price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Модель: {Model}, Производитель: {Manufacturer}, Цена: {Price} руб.");
        }
    }
}
