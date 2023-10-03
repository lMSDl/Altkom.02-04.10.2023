using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.SOLID.L;

namespace WPC
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Structural.Facade.I.Client.Execute();


            /*var rectangle = GetRectangle();

            var a = 5;
            var b = 3;

            rectangle.A = a;
            rectangle.B = b;

            Console.WriteLine($"{a}*{b} = {rectangle.Area}");*/


            Console.ReadLine();
        }

        static Rectangle GetRectangle()
        {
            return new Square();
        }
    }
}
