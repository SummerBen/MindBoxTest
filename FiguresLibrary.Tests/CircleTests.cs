using FiguresLibrary.models;
using System.Linq.Expressions;
using System;

namespace FiguresLibrary.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void IsExist_InputUncorrectValue_ArgumentExceptionReturned(double value)
        {
            Assert.Throws<ArgumentException>(() => new Circle(value).IsExist());
        }

        [Fact]
        public void IsExist_InputCorrectValue_ReturnedTrue()
        {
            Circle circle = new Circle(1);

            bool result = circle.IsExist();

            Assert.True(result);
        }

        [Fact]
        public void Square_InputRadius_ReturnedSquare()
        {
            Circle circle = new Circle(10);

            double result = circle.square;

            Assert.Equal(314.15926535897933, result);
        }
    }
}