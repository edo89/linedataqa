using System;
using DataTypes7;
using Xunit;

namespace String.Tests
{
    public class StringTests
    {
        [Fact]
        public void ReverseStringCheck()
        {
            //Arrange
            var somestring = "HELLO";
            //Act
            var actual = StringR.Reverse(somestring);
            var expected = "OLLEH";
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseStringCheck2()
        {
            //Arrange
            var somestring = "1234";
            //Act
            var actual = StringR.Reverse(somestring);
            var expected = "4321";
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
