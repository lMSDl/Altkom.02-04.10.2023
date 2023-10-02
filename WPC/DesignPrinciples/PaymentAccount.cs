﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPrinciples
{
    public class PaymentAccount
    {
        public float Income { get; private set; }
        public float Outcome { get; private set; }
        public float AllowedDebit { get; set; }


        public void Charge(float amount)
        {
            if (Income - Outcome + AllowedDebit < amount)
            {
                throw new Exception("Not possible");
                //return false;
            }

            Outcome += amount;
            //return true;
        }
        public void Fund(float amount)
        {
            Income += amount;
        }
    }
}
