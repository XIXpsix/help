using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Zakaz
    {
        private string fam;
        private int size;
        private string comfort;

        // Конструктор без параметров
        public Zakaz()
        {
            fam = "Не указано";
            size = 1;
            comfort = "Стандарт";
        }

        // Конструктор с фамилией
        public Zakaz(string fam)
        {
            this.fam = fam;
            size = 1;
            comfort = "Стандарт";
        }

        // Конструктор с фамилией и количеством мест
        public Zakaz(string fam, int size)
        {
            this.fam = fam;
            this.size = size;
            comfort = "Стандарт";
        }

        // Конструктор с фамилией, количеством мест и комфортом
        public Zakaz(string fam, int size, string comfort)
        {
            this.fam = fam;
            this.size = size;
            this.comfort = comfort;
        }

        public void Show()
        {
            Console.WriteLine($"Фамилия: {fam}, Количество мест: {size}, Комфорт: {comfort}");
        }
    }
}
