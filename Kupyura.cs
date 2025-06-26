using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Kupyura
    {
        private string name;
        private int nominal;
        private int count;

        public string Name
        {
            get { return name; }
            set { name = string.IsNullOrWhiteSpace(value) ? "Неизвестно" : value; }
        }

        public int Nominal
        {
            get { return nominal; }
            set { nominal = value > 0 ? value : 1; }
        }

        public int Count
        {
            get { return count; }
            set { count = value >= 0 ? value : 0; }
        }

        // Конструктор по умолчанию
        public Kupyura()
        {
            Name = "Неизвестно";
            Nominal = 1;
            Count = 0;
        }

        // Конструктор с параметрами
        public Kupyura(string name, int nominal, int count)
        {
            Name = name;
            Nominal = nominal;
            Count = count;
        }

        // Конструктор с одним параметром
        public Kupyura(string name)
        {
            Name = name;
            Nominal = 1;
            Count = 0;
        }

        public void Show()
        {
            Console.WriteLine($"Название: {Name}, Номинал: {Nominal}, Количество: {Count}");
        }

        // Изменить количество купюр
        public void ChangeCount(int delta)
        {
            int newCount = Count + delta;
            Count = newCount >= 0 ? newCount : 0;
        }

        // Проверить, достаточно ли суммы для оплаты
        public bool EnoughFor(decimal price)
        {
            return (Nominal * Count) >= price;
        }
    }
}
