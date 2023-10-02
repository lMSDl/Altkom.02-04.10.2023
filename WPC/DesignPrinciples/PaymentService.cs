using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            return customer?.PaymentAccount.Charge(amount) ?? false;
        }

        public void Fund(Customer customer, float amount)
        {
            customer?.PaymentAccount?.Fund(amount);
        }
    }
}
