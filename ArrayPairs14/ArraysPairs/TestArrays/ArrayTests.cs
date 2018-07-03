using ArraysPairs;
using Xunit;
using Xunit.Abstractions;

namespace TestArrays
{
    public class ArrayTests
    {
        private readonly ITestOutputHelper _output;

        public ArrayTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestPairsPairAmountMoreThan100K()
        {
            var smth = new Pairs();

            int[] bigArray = new int[1000];
            for (var i = 0; i < bigArray.Length; i += 1)
                bigArray[i] = 5;

            ////another way of populating big array, but hard to compare with expected results
            //int size = 5;
            //int[] randomNumbers = new int [size];
            //for (int i = 0; i < size; i++)
            //{
            //    Random r = new Random();
            //    randomNumbers[i] = r.Next(0, 9);
            //}

            int n = bigArray.Length;
            var actual = smth.GetPairs(bigArray, n);

            var expected = 100000;
            _output.WriteLine(actual.ToString());
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPairsPairAmountLessThan100K()
        {
            var smth = new Pairs();

            int[] bigArray = new int[100];
            for (var i = 0; i < bigArray.Length; i += 1)
                bigArray[i] = 5;

            ////another way of populating big array, but hard to compare with expected results
            //int size = 5;
            //int[] randomNumbers = new int [size];
            //for (int i = 0; i < size; i++)
            //{
            //    Random r = new Random();
            //    randomNumbers[i] = r.Next(0, 9);
            //}

            int n = bigArray.Length;
            var actual = smth.GetPairs(bigArray, n);

            var expected = 4950;
            _output.WriteLine(actual.ToString());
            Assert.Equal(expected, actual);
        }
    }
}
