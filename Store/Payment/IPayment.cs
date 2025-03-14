using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Payment
{
    internal interface IPayment
    {
        void ProcessPayment(decimal amount);
    }
}
