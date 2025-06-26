using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Computer
    {
        private string model;
        private int ram;   // ГБ
        private int hdd;   // ГБ
        private decimal price;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 2) ram = 2;
                else if (value > 32) ram = 32;
                else ram = value;
            }
        }

        public int Hdd
        {
            get { return hdd; }
            set
            {
                if (value < 200) hdd = 200;
                else if (value > 2000) hdd = 2000;
                else hdd = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Computer(string model, int ram, int hdd, decimal price)
        {
            Model = model;
            Ram = ram;
            Hdd = hdd;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Модель: {Model}, ОЗУ: {Ram} ГБ, HDD: {Hdd} ГБ, Цена: {Price} руб.");
        }
    }
}
