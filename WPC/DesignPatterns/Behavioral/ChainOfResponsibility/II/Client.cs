using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    class Client
    {
        public static void Execute()
        {
            var textBoxFrame = new Frame() { Name = "textBoxFrame" };
            var textBox = new TextBox() { Name = "textBox" };

            textBoxFrame.Add(textBox);


            var buttonFrame = new Frame() { Name = "buttonFrame" };
            var button = new Button() { Name = "button" };
            button.OnClick = () =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return false;
                textBox.Text = null;
                return true;
            };

            buttonFrame.Add(button);

            textBox.Add(buttonFrame);

            Console.WriteLine("-----");
            textBoxFrame.Click();

            Console.WriteLine("-----");
            button.Click();

            Console.WriteLine("-----");
            textBox.Click();

            Console.WriteLine("-----");
            textBox.Text = "ala ma kota";

            Console.WriteLine("-----");
            button.Click();

            Console.WriteLine("-----");
            button.Click();
        }
    }
}
