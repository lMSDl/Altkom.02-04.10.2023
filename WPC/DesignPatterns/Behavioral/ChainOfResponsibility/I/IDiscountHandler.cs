using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    interface IDiscountHandler
    {
        bool Discount(float discountValue, float productsPrice);
    }
}
