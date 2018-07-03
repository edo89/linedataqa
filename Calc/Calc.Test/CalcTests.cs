using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Calc.Test
{
    
    public class CalcTests
    {
        [Fact]
        public void TestAddition()

        
        {
            Calculator action = new Calculator();

            //Arrange
            var num1 = 10;
            var num2 = 2;

            //Act
            var actual = action.Addition(num1, num2);
            var expected = 12;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubstraction()
        {
            Calculator action = new Calculator();

            //Arrange
            var num1 = 10;
            var num2 = 2;

            //Act
            var actual = action.Substraction(num1, num2);
            var expected = 8;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubstractionNum2MoreThanNum1()
        {
            Calculator action = new Calculator();

            //Arrange
            var num1 = 2;
            var num2 = 10;

            //Act
            var actual = action.Substraction(num1, num2);
            var expected = 8;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplication()
        {
            Calculator action = new Calculator();

            //Arrange
            var num1 = 10;
            var num2 = 2;

            //Act
            var actual = action.Multiplication(num1, num2);
            var expected = 20;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivision()
        {
            Calculator action = new Calculator();

            //Arrange
            var num1 = 10;
            var num2 = 2;

            //Act
            var actual = action.Division(num1, num2);
            var expected = 5;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
