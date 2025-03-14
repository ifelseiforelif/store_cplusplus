using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Payment
{
    internal class CreditCardPayment:IPayment
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(string cardNumber) => CardNumber = cardNumber;

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплата {amount} грн. произведена с карты {CardNumber}");
        }
    }
}
