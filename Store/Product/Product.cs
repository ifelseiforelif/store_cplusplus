using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Product
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Store.Category.Category Category { get; set; } // Агрегация
        public Store.Supplier.Supplier Supplier { get; set; } // Композиция

        public Product(string name, decimal price, Store.Category.Category category, Store.Supplier.Supplier supplier)
        {
            Name = name;
            Price = price;
            Category = category;
            Supplier = supplier ?? throw new ArgumentNullException(nameof(supplier));
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {Category.Name}, Цена: {Price} грн.");
            Console.WriteLine($"Поставщик: {Supplier.Name}");
            Category.DisplayCategoryInfo();
        }
    }
}
