using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    class TextBox : Container
    {
        private string text;

        public string Text
        {
            get => text;
            set
            {
                text = value;
                Console.WriteLine($"{Name} zmienił wartość na {value}");
            }
        }

        protected override void Click(bool handled)
        {
            if (!handled)
            {
                Console.WriteLine($"{Name} złapał focus");
                base.Click(true);
            }
            else base.Click(handled);
        }
    }
}
