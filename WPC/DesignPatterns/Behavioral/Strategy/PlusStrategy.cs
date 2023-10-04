using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Strategy
{
    class PlusStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a + b;
        }
    }
}
