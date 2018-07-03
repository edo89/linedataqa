using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProject
{
    public class Triangle : Shape
    {
        public double Base;
        public double Height;

        public Triangle(string name, double bBase, double height) : base(name)
        {
            Base = bBase;
            Height = height;
        }

        public override double GetArea()
        {
            double area = (Height * Base) / 2;
            return area;
        }
        public override string GetName()
        {
            return "I think this should be: " + Name;
        }
    }
}
