using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.SOLID.O
{
    abstract class Shape
    {
        public abstract double Area {get;}
        //public abstract double GetArea();
    }

    class Square : Shape
    {
        public int A { get; set; }

        public override double Area => A * A;

        /*public override double GetArea()
        {
            return A * A;
        }*/
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public override double Area => A * B;

        /*public override double GetArea()
        {
            return A * B;
        }*/
    }

    class Circle : Shape
    {
        public int R { get; set; }
        public override double Area => R * R * Math.PI;

        /*public override double GetArea()
        {
            return R * R * Math.PI;
        }*/
    }

    class ShapeCalculator
    {
        double Area(Shape shape)
        {
            return shape.Area;
        }
    }

            /*class ShapeCalculator
            {
                double Area(Shape shape)
                {
                    switch (shape)
                    {
                        case Square square:
                            return square.A * square.A;
                        case Rectangle rectangle:
                            return rectangle.A * rectangle.B;
                        case Circle circle:
                            return Math.PI * circle.R * circle.R;
                        default:
                            return 0;
                    }
                }
            }*/
        }
