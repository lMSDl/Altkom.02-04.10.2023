using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    interface IComponent
    {
        string Name { get; }
        float GetValue();
    }
}
