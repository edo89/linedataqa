using System;
using System.Collections.Generic;
using System.Text;

namespace TaxProject
{
   public class Vehicle
    {
        protected int RegNumber { get; set; }
        protected double MaxVelocity { get; set; }
        protected decimal Value { get; set; }

        public Vehicle(int regNumber, double maxVelocity, decimal value)
        {
            RegNumber = regNumber;
            MaxVelocity = maxVelocity;
            Value = value;
        }
    }
}
