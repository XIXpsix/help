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
            Address address = new Address();
            address.Index = "123456";
            address.Country = "Россия";
            address.City = "Москва";
            address.Street = "Тверская";
            address.House = "10";
            address.Apartment = "25";

            Console.WriteLine("Почтовый адрес:");
            Console.WriteLine($"Индекс: {address.Index}");
            Console.WriteLine($"Страна: {address.Country}");
            Console.WriteLine($"Город: {address.City}");
            Console.WriteLine($"Улица: {address.Street}");
            Console.WriteLine($"Дом: {address.House}");
            Console.WriteLine($"Квартира: {address.Apartment}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
