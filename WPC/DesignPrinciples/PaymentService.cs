using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(Customer customer, float amount)
        {
            try
            {
                customer.PaymentAccount.Charge(amount);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Fund(Customer customer, float amount)
        {
            customer?.PaymentAccount?.Fund(amount);
        }
    }
}
