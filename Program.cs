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

            Console.Write("Введите фамилию сотрудника: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя сотрудника: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите должность (менеджер, инженер, директор): ");
            string position = Console.ReadLine();
            Console.Write("Введите стаж (лет): ");
            int experience = int.Parse(Console.ReadLine());

            Employee employee = new Employee(lastName, firstName);
            employee.CalculateSalary(position, experience, out double salary, out double tax);

            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine($"Фамилия: {employee.LastName}");
            Console.WriteLine($"Имя: {employee.FirstName}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Оклад: {salary:F2} BYN");
            Console.WriteLine($"Налоговый сбор (13%): {tax:F2} BYN");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
