using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Order
{
    internal class Order:IOrder
    {
        private List<Store.Product.Product> products = new List<Store.Product.Product>();

        public void AddProduct(Store.Product.Product product) => products.Add(product);

        public decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var product in products)
                total += product.Price;
            return total;
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Список товаров в заказе:");
            foreach (var product in products)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }
            Console.WriteLine($"Общая сумма заказа: {GetTotalAmount()} грн.");
        }
    }
}
