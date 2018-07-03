using System;
using CarsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
//using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Cars.Test
{

    public class CarsTest
    {
        [Fact]
        public void BuildFerrari()
        {
            var car = new Ferrari()

            //inherited members from Car class
            {
                CarModel = "Ferrari",
                EngineType = "V.1 4500CC",
                TyreType = "MRF TubeLess Tyre",
                SoundSystemType = "Sony Dolby Digital Extra Bass",
            };

            //test for one of the properties
            var actual1 = car.CarModel;

            //test for interface
            var actual2 = "SkyBlue";

            Xunit.Assert.Equal(actual1, car.CarModel);
            Xunit.Assert.Equal(actual2, car.CustomColour());

        }

        [Fact]
        public void BuildBMW()
        {
            var car = new BMW()

                //inherited members from Car class
                {
                    CarModel = "BMW",
                    EngineType = "V.2 5500CC Engine",
                    TyreType = "MRF TubeLess Tyre",
                    SoundSystemType = "Sony Dolby Digital Extra Bass",
                };

            var actual1 = car.CarModel;

            //test for interface
            var actual2 = "Red";

            Xunit.Assert.Equal(actual1, car.CarModel);
            Xunit.Assert.Equal(actual2, car.CustomColour());

        }

    }
}
