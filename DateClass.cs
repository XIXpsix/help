using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class DateClass
    {
        private DateTime data;

        // a. поле DateTime data (реализовано выше)

        // b. конструктор без параметров
        public DateClass()
        {
            data = DateTime.Now;
        }

        // c. конструктор с тремя параметрами
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        // d. свойство для доступа к дате
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // e. метод для предыдущего дня
        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        // f. метод для следующего дня
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }

        public void Show()
        {
            Console.WriteLine($"Текущая дата: {data.ToShortDateString()}");
        }
    }
}
