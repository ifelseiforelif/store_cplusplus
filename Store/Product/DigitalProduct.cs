using Store.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Product
{
    internal class DigitalProduct:Product
    {
        public string ActivationKey { get; set; }

        public DigitalProduct(string name, decimal price, Store.Supplier.Supplier supplier, string activationKey)
            : base(name, price, new DigitalCategory(), supplier)
        {
            ActivationKey = activationKey;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Ключ активации: {ActivationKey}");
        }
    }
}
