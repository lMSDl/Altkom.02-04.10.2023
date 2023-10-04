using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.I
{
    class Client
    {
        public static void Execute()
        {
            var collection = new IElement[]
{
                new PlainText() {Text = "Plain"},
                new PlainText() { Text = "\n" },
                new BoldText() {Text = "Bold"},
                new PlainText() { Text = "\n" },
                new Hyperlink() {Text = "Hyperlink",  Link=@"https:\\some.url.pl"},
};

            var visitor = new HtmlVisitor();
            foreach (var item in collection)
            {
                item.Accept(visitor);
            }

            Console.WriteLine(visitor);
        }
    }
}
