using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Payment
{
    internal class PayPalPayment:IPayment
    {
        public string Email { get; set; }

        public PayPalPayment(string email) => Email = email;

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплата {amount} грн. произведена через PayPal ({Email})");
        }
    }
}
