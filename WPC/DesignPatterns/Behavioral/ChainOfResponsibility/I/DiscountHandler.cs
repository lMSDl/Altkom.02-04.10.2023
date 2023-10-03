using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    class DiscountHandler : IDiscountHandler
    {
        private IDiscountHandler _nextHandler;
        public string Name { get; }
        public float MaxDiscount { get; }
        public float MinPrice { get; }
        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }
        public DiscountHandler(string name, float maxDiscount, float minPrice, IDiscountHandler nextHandler)
        {
            Name = name;
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
            _nextHandler = nextHandler;
        }


        public bool Discount(float discountValue, float productsPrice)
        {
            if (MinPrice <= productsPrice && discountValue <= MaxDiscount)
            {
                Console.WriteLine($"{Name} udzielił rabatu");
                return true;
            }
            return _nextHandler?.Discount(discountValue, productsPrice) ?? false;
        }
    }
}
