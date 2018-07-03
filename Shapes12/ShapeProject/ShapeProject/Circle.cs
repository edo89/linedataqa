using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProject
{
    public class Circle : Shape
    {
        private double _radius;

        //own properties + name from base
        public Circle(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            double area = Math.Pow(_radius, 2.00) * Math.PI;
            return area;
        }
        public override string GetName()
        {
            return "This is overriden: " + Name;
        }
    }
}
