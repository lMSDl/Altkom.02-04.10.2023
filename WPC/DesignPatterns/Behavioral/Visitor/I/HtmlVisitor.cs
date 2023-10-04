using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.I
{
    class HtmlVisitor : IVisitor
    {
        private StringBuilder StringBuilder { get; } = new StringBuilder();

        public void Visit(BoldText element)
        {
            StringBuilder.Append($"<b>{element.Text}</b>");
        }

        public void Visit(PlainText element)
        {
            StringBuilder.Append(element.Text);
        }

        public void Visit(Hyperlink element)
        {
            StringBuilder.Append($"<a href={element.Link}>{element.Text}</a>");
        }

        public override string ToString()
        {
            return StringBuilder.ToString();
        }
    }
}
