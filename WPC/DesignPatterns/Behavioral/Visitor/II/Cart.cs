using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.II
{
    class Cart : Basket
    {
        public override void Add(Product product)
        {
            Console.WriteLine("Produkt w wózku");
        }
        public override void Add(BoxedProduct product)
        {
            Console.WriteLine("Karton produktu w wózku");
        }
    }
}
