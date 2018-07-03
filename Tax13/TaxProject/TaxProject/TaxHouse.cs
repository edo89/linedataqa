using System;
using System.Collections.Generic;
using System.Text;

namespace TaxProject
{
   public class TaxHouse : House, ITaxable
    {
        public TaxHouse(string location, bool inCity, double area, decimal value) : base(location, inCity, area, value)
        {
        }

        public decimal TaxValue()
        {
            if (InCity)
                return Value * 0.28m;
           
           return Value * 0.18m;
        }
    }
}
