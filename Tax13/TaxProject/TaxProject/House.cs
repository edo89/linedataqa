using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TaxProject
{
   public class House : FixedProperty
    {
        public double Area { get; set; }

        public House(string location, bool inCity, double area, decimal value) : base(location, inCity, value)
        {
            Area = area;
        }
    }
}
