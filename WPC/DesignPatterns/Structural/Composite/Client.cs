using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Composite
{
    class Client
    {
        public static void Execute()
        {

            var warehouse = new Warehouse();

            var shelf1 = new Shelf();
            var shelf2 = new Shelf();

            warehouse.Components.Add(shelf1);
            warehouse.Components.Add(shelf2);

            var box1 = new Box();
            var box2 = new Box();
            var box3 = new Box();
            var box4 = new Box();

            shelf1.Components.Add(box1);
            shelf2.Components.Add(box2);
            shelf2.Components.Add(box3);

            warehouse.Components.Add(box4);

            for (int i = 0; i < 10; i++)
            {
                box1.Components.Add(new Cookie(4));
                box2.Components.Add(new Tea(16));
                box3.Components.Add(new Toy(54.2f));
            }

            for (int i = 0; i < 5; i++)
            {
                box4.Components.Add(new Cookie(4));
                box4.Components.Add(new Tea(16));
            }

            shelf1.Components.Add(new Toy(12));

            warehouse.GetValue();

            box1.GetValue();
            shelf1.GetValue();
        }
    }
}
