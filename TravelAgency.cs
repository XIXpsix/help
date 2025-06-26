using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class TravelAgency
    {
        public string Name { get; set; }
        public int YearFounded { get; set; }
        public string INN { get; set; }
        public decimal Profit { get; set; }

        public TravelAgency(string name, int yearFounded, string inn, decimal profit)
        {
            Name = name;
            YearFounded = yearFounded;
            INN = inn;
            Profit = profit;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название: {Name}, Год основания: {YearFounded}, ИНН: {INN}, Прибыль: {Profit} руб.");
        }
    }
}
