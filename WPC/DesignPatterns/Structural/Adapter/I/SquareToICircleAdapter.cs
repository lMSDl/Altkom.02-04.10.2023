using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Adapter.I
{
    class SquareToICircleAdapter : ICircle
    {
        private readonly Square _square;

        public SquareToICircleAdapter(Square square)
        {
            _square = square;
        }

        public float Radius => (float)(_square.Width * Math.Sqrt(2) / 2f);
    }
}
