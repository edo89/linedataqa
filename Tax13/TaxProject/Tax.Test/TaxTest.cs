using System;
using Xunit;
using TaxProject;
using Xunit.Abstractions;

namespace Tax.Test
{
    public class TaxTest
    {
        private readonly ITestOutputHelper _output;

        public TaxTest (ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestSomeTaxing()
        {   //tax calculation
            ITaxable[] taxObjects =
                {
                    new TaxBus(30, 222222, 300000),
                    new TaxBus(25, 3333, 25000),
                    new TaxHouse("Riga", true, 304, 3000),
                    new TaxHouse("Vilnius", false, 401, 4000)};

            //new result array
            int[] expectedValue = { 18000, 1250, 840, 720 };

            for (int i = 0; i < taxObjects.Length; i++)
            {
                //compare result array with tax calculated objects array
                Assert.Equal(expectedValue[i], taxObjects[i].TaxValue());
                _output.WriteLine("Expected {0} and Actual {1}", expectedValue[i], taxObjects[i].TaxValue());
            }
        }
    }
}
