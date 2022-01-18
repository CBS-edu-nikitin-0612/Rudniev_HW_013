using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Invoice
    {
        private readonly int account;
        private readonly string customer, provider;
        private string article;
        private int quantity;

        public string Article { get => article; set => article = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Invoice() { }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void Calculator(string article, int quantity)
        {
            this.Article = article;
            this.Quantity = quantity;

            double amount = 0;
            if (Article == "iphone10")
                amount = Quantity * 15000;

            Console.WriteLine("Article: " + Article + ";");
            Console.WriteLine("Quantity: " + Quantity + ";");
            Console.WriteLine("Сумма с НДС: " + amount + "грн;");
            Console.WriteLine("Сумма без НДС: " + (amount - amount * 0.2) + "грн;");
        }
    }
}
