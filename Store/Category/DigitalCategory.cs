using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Category
{
    internal class DigitalCategory:Category
    {
        public DigitalCategory() : base("Цифровой товар") { }
        public override void DisplayCategoryInfo() => Console.WriteLine("Этот товар доставляется в цифровом виде.");
    }
}
