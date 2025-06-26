using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Employee
    {
        private string lastName;
        private string firstName;

        public string LastName { get { return lastName; } }
        public string FirstName { get { return firstName; } }

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // Метод для расчёта оклада и налога
        public void CalculateSalary(string position, int experience, out double salary, out double tax)
        {
            // Базовые оклады по должности
            double baseSalary;
            switch (position.ToLower())
            {
                case "менеджер":
                    baseSalary = 1200;
                    break;
                case "инженер":
                    baseSalary = 1500;
                    break;
                case "директор":
                    baseSalary = 2500;
                    break;
                default:
                    baseSalary = 1000;
                    break;
            }

            // Надбавка за стаж: 3% за каждый год, максимум 30%
            double experienceBonus = Math.Min(experience * 0.03, 0.3);
            salary = baseSalary * (1 + experienceBonus);

            // Налог: 13%
            tax = salary * 0.13;
        }
    }
}
