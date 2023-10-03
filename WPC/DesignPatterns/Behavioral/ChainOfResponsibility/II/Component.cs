using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    abstract class Component
    {
        public string Name { get; set; }
        public Component Parent { get; set; }

        public void Click()
        {
            Click(false);
        }

        protected virtual void Click(bool handled)
        {
            Parent?.Click(handled);
        }
    }
}
