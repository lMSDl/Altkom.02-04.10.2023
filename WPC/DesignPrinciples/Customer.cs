using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }

        public PaymentAccount PaymentAccount { get; } = new PaymentAccount();
    }
}