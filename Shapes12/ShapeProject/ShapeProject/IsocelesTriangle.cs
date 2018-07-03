using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProject
{
    public class IsocelesTriangle : Triangle
    {
        public IsocelesTriangle(string name, double bBase, double height) : base(name, bBase, height)
        {
        }

        public override double GetArea()
        {
            return base.GetArea();
        }
        public override string GetName()
        {
            return "My Parent is triangle: " + Name;
        }
    }
}
