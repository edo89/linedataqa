using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProject
{
   public class Rectangle : Shape
    {
        private double _side1;
        private double _side2;

        //own properties + name from base
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public override double GetArea()
        {
            double area = _side1 * _side2;
            return area;
        }

        public override string GetName()
        {
            return "The shape of this is: " + Name;
        }
    }
}

