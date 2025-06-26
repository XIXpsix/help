using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Invoice
    {// Только для чтения, инициализируются в конструкторе
        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }

        // Закрытые поля
        private string article;
        private int quantity;

        // Конструктор
        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        // Метод расчёта стоимости без НДС
        public double GetTotalWithoutVAT(double pricePerItem)
        {
            return pricePerItem * quantity;
        }

        // Метод расчёта стоимости с НДС (20%)
        public double GetTotalWithVAT(double pricePerItem)
        {
            double total = GetTotalWithoutVAT(pricePerItem);
            return total * 1.2;
        }
    }
}
