using System;
using System.Collections.Generic;
using System.Text;

namespace TaxProject
{
    public class Bus : Vehicle
    {
        protected int NumberOfSeats { get; set; }

        public Bus(int numberOfSeats, int regNumber, decimal value) : base(regNumber, 90, value)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
