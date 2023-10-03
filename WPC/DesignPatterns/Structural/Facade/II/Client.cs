using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Facade.II
{
    class Client
    {
        public static void Execute()
        {
            /*IPaymentService paymentService = null;
            IProductService productService = null;
            ICartService cartService = null;*/


            int[] productIds = new[] { 12, 251, 22134, 221 };


            /*foreach (var productId in productIds)
            {
                var price = productService.GetPrice(productId);
                cartService.AddProduct(productId, price);
            }
            paymentService.Pay(cartService.GetId(), cartService.GetValue());*/

            ShopFacade shop = new ShopFacade();

            shop.Buy(productIds);


        }

    }
}
