using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Strategy
{
    class Calculator
    { 
        public ICalcStrategy Strategy { get; set; }

        public float? Operate(float a, float b)
        {
            return Strategy.Calc(a, b);
        }
    }
}
