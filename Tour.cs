using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Tour
    {// Без параметров
        public void TourCalc()
        {
            Console.WriteLine("Тур: Минское море, бесплатно");
        }

        // Один параметр (страна)
        public void TourCalc(string country)
        {
            Console.WriteLine($"Тур: {country}, 1 день, стоимость: 50 руб.");
        }

        // Два параметра (страна, количество дней)
        public void TourCalc(string country, int days)
        {
            int cost = 50 * days;
            Console.WriteLine($"Тур: {country}, {days} дней, стоимость: {cost} руб.");
        }
    }
}
