using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class InsuranceClient
    {
        public string Name { get; set; }
        public string InsuranceType { get; set; }
        public decimal InsuranceAmount { get; set; }

        public InsuranceClient(string name, string insuranceType, decimal insuranceAmount)
        {
            Name = name;
            InsuranceType = insuranceType;
            InsuranceAmount = insuranceAmount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {Name}, Вид страховки: {InsuranceType}, Размер страховки: {InsuranceAmount} руб.");
        }
    }
}
