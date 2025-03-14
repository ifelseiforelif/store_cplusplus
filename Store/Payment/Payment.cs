using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Payment
{
    internal class Payment
    {
        public Store.Order.Order Order { get; set; }
        public IPayment PaymentMethod { get; set; }

        public Payment(Store.Order.Order order, IPayment paymentMethod)
        {
            Order = order;
            PaymentMethod = paymentMethod;
        }



        public void CompletePayment()
        {
            decimal amount = Order.GetTotalAmount();
            PaymentMethod.ProcessPayment(amount);
        }
    }
}
