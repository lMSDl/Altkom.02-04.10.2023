using System.Collections.Generic;
using System.Linq;

namespace DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }


        public bool Charge(float amount)
        {
            if (Income - Outcome + AllowedDebit < amount)
            {
                return false;
            }

            Outcome += amount;
            return true;
        }
        public void Fund(float amount)
        {
            Income += amount;
        }
    }
}