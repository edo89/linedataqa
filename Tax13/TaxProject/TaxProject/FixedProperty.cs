using System;
using System.Collections.Generic;
using System.Text;

namespace TaxProject
{
   public class FixedProperty
    {
        protected string Location { get; set; }
        protected bool InCity { get; set; }
        protected decimal Value { get; set; }

        public FixedProperty(string location, bool inCity, decimal value)
        {
            Location = location;
            InCity = inCity;
            Value = value;
        }   
    }
}
