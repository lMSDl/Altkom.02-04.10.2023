using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    class Frame : Container
    {
        protected override void Click(bool handled)
        {
            if(handled)
                Console.WriteLine($"{Name} zamigotał na zielono");
            else
                Console.WriteLine($"{Name} zamigotał na czerwono");

            base.Click(handled);
        }
    }
}
