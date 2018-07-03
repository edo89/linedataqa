using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProject
{
    public class Square : Rectangle
    {
        public double Side1;

        public Square(string name, double side1) : base(name, side1, side1)
        {
            Side1 = side1;
        }

        public override double GetArea()
        {
            double area = Math.Pow(Side1, 2.00);
            return area;
        }

        public override string GetName()
        {
            return "This shape is derived from rectangle: " + Name;
        }
    }
}
