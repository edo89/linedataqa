using System;

namespace TaxProject
{
    public class TaxBus : Bus, ITaxable
    {
        public TaxBus(int numberOfSeats, int regNumber, decimal value) : base(numberOfSeats, regNumber, value)
        {

        }

        public decimal TaxValue()
        {
            return (Value / 100) * NumberOfSeats * 0.2m;
        }
    }
}
