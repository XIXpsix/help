using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            InsuranceClient[] clients = new InsuranceClient[]
            {
                new InsuranceClient("Иванов И.И.", "Автомобиль", 2500),
                new InsuranceClient("Петров П.П.", "Жильё", 1500),
                new InsuranceClient("Сидоров С.С.", "Автомобиль", 1800),
                new InsuranceClient("Кузнецова А.А.", "Автомобиль", 3000)
            };

            Console.WriteLine("Клиенты, застраховавшие автомобиль на сумму более 2000 руб.:");
            foreach (var client in clients)
            {
                if (client.InsuranceType == "Автомобиль" && client.InsuranceAmount > 2000)
                    client.ShowInfo();
            }

            int autoCount = 0;
            foreach (var client in clients)
            {
                if (client.InsuranceType == "Автомобиль")
                    autoCount++;
            }
            Console.WriteLine($"Количество клиентов с автомобильной страховкой: {autoCount}");
        }
    }
}
