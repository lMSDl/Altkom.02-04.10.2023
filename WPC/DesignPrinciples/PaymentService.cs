using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public bool Charge(int customerId, float amount)
        {
            var customer = GetCustomerById(customerId);
            return customer?.Charge(amount) ?? false;
        }

        private Customer GetCustomerById(int customerId)
        {
            return Customers.SingleOrDefault(x => x.Id == customerId);
        }

        public void Fund(int customerId, float amount)
        {
            var customer = GetCustomerById(customerId);
            customer?.Fund(amount);
        }
    }
}
