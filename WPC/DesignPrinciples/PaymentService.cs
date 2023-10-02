using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {

        public bool Charge(PaymentAccount account, float amount)
        {
            try
            {
                account.Charge(amount);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Fund(PaymentAccount account, float amount)
        {
            account?.Fund(amount);
        }
    }
}
