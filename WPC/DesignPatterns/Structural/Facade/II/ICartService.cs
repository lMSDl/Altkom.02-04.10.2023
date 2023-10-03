using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.II
{
    interface ICartService
    {
        void AddProduct(int productId, float price);
        float GetValue();
        int GetId();
    }
}
