using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.II
{
    class Basket : IVisitor
    {
        public virtual void Add(Product product)
        {
            Console.WriteLine("Produkt w koszyku");
        }
        public virtual void Add(BoxedProduct product)
        {
            Console.WriteLine("Karton produktu jest za duży do koszyka");
        }

        public void Visit(Product product)
        {
            Add(product);
        }

        public void Visit(BoxedProduct product)
        {
            Add(product);
        }
    }
}
