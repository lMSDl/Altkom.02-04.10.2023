using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.I
{
    class SquareToCircleConverter
    {
        public static Circle Convert(Square square)
        {
            return new Circle() { Radius = (float)(square.Width * Math.Sqrt(2) / 2f) };
        }
    }
}
