using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Order
{
    internal interface IOrder
    {
        void AddProduct(Store.Product.Product product);
        void DisplayOrder();
    }
}
