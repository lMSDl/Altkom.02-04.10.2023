using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.I
{
    class Client
    {
        public static void Execute()
        {
            Shape shape = new Rectangle(); 
            shape.Color = new Red();
            Console.WriteLine(shape);



            shape = new Triangle();
            shape.Color = new Blue();
            Console.WriteLine(shape);
        }
        }
}
