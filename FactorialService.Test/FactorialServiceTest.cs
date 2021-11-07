using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FactorialService.Test
{
    public class FactorialServiceTest
    {
        //[Fact]
        //public void CalculateFactorial_Input3_Return6()
        //{

        //    //Arrange
        //    FactorialService factorialService = new FactorialService();
        //    //Act
        //    var value = factorialService.CalculateFactorial(3);
        //    //Assert
        //    Assert.Equal(6, value);
        //}

        [Theory]
        [InlineData(0, 1)]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        [InlineData(12, 479001600)]
        public void CalculateFactorial_LessThan13PositiveNumbers_ReturnSuccesfully(int input, int expected)
        {
            //Arrange
            FactorialService factorialService = new FactorialService();
            //Act
            var value = factorialService.CalculateFactorial(input);
            //Assert
            Assert.Equal(expected, value);
        }


        [Theory]
        [InlineData(-5)]
        [InlineData(-1)]
        [InlineData(13)]
        [InlineData(15)]
        public void CalculateFactorial_NegativeAndMoreThan12Numbers_ThrowArgumentOutOfRangeException(int input)
        {
            //Arrange
            FactorialService factorialService = new FactorialService();
            //Act
            Action actual = () => factorialService.CalculateFactorial(input);
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(actual);
        }
    }
}
