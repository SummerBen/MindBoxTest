using FiguresLibrary.interfaces;

namespace FiguresLibrary.models
{
    public class Circle : IFigure
    {
        public double radius;

        public double square
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public bool IsExist()
        {
            return radius > 0 ? true : throw new ArgumentException();
        }

        public Circle(double radius)
        {
            this.radius = radius;
            IsExist();
        }
    }
}