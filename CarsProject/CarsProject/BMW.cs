using System;
using System.Collections.Generic;
using System.Text;

namespace CarsProject
{
    public class BMW : Car, ICustomColour
    {
        public string CustomColour()
        {
            var colour = "Red";

            return colour;
        }
    }
}
