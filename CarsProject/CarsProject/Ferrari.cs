using System;
using System.Collections.Generic;
using System.Text;

namespace CarsProject
{
    public class Ferrari : Car, ICustomColour
    {
        public string CustomColour()
        {
            var colour = "SkyBlue";

            return colour;
        }
    }
}
