using FiguresLibrary.models;
using System.Linq.Expressions;
using System;

namespace FiguresLibrary.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(1, 1, 3)]
        [InlineData(1, 3, 1)]
        [InlineData(3, 1, 1)]
        public void IsExist_InputUncorrectValues_ArgumentExceptionReturned(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c).IsExist());
        }

        [Fact]
        public void IsExist_InputCorrectValues_ReturnedTrue()
        {
            Triangle triangle = new Triangle(2, 3, 4);

            bool result = triangle.IsExist();

            Assert.True(result);
        }

        [Fact]
        public void IsRectangular_Sides_ReturnedTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool result = triangle.isRectangular;

            Assert.True(result);
        }

        [Fact]
        public void P_Sides_HalfMeterReturned()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double result = triangle.p;

            Assert.Equal(6, result);
        }

        [Fact]
        public void Square_Sides_ReturnedSquare()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double result = triangle.square;

            Assert.Equal(6, result);
        }
    }
}
