using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Category
{
    internal class PhysicalCategory: Category
    {
        public PhysicalCategory() : base("Физический товар") { }
        public override void DisplayCategoryInfo() => Console.WriteLine("Этот товар требует физической доставки.");
    }
}
