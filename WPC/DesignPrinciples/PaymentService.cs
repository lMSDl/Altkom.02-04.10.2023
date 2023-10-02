using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public bool DeleteCustomer(Customer customer)
        {
            return Customers.Remove(customer);
        }

        public Customer FindByAllowedDebit(float allowedDebit)
        {
            return Customers.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int customerId, float amount)
        {
            var customer = GetCustomerById(customerId);
            if (customer == null)
            {
                return false;
            }

            if (GetBalance(customerId) + customer.AllowedDebit < amount)
            {
                return false;
            }

            customer.Outcome += amount;
            return true;
        }

        private Customer GetCustomerById(int customerId)
        {
            return Customers.SingleOrDefault(x => x.Id == customerId);
        }

        public void Fund(int customerId, float amount)
        {
            var customer = GetCustomerById(customerId);
            if (customer == null)
            {
                return;
            }

            customer.Income += amount;
        }

        public float? GetBalance(int customerId)
        {
            var customer = GetCustomerById(customerId);
            return customer?.Income - customer?.Outcome;
        }
    }
}
