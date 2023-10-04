using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Visitor.I
{
    class PlainText : IElement
    {
        public string Text { get; set; }

        public string ToHtml()
        {
            return Text;
        }
    }
}
