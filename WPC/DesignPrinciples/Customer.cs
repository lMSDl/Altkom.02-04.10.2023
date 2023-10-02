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
        public float Income { get; set; }
        public float Outcome { get; set; }
        public float AllowedDebit { get; set; }

        //public bool HasDebit => Income - Outcome < 0;
        public bool HasDebit()
        {
            return Income - Outcome < 0;
        }
    }
}