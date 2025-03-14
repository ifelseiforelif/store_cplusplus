using Store.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Product
{
    internal class Electronics:Product
    {
        public string Model { get; set; }
        public int WarrantyMonths { get; set; }

        public Electronics(string name, string model, decimal price, Store.Supplier.Supplier supplier, int warrantyMonths)
            : base(name, price, new PhysicalCategory(), supplier)
        {
            Model = model;
            WarrantyMonths = warrantyMonths;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Модель: {Model}, Гарантия: {WarrantyMonths} месяцев");
        }
    }
}
