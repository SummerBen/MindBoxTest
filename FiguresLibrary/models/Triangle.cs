using FiguresLibrary.interfaces;

namespace FiguresLibrary.models
{
    public class Triangle : IFigure
    {
        public double a;
        public double b;
        public double c;
        public double p
        {
            get
            {
                return (a + b + c) / 2;
            }
        }

        public double square
        {
            get
            {
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public bool isRectangular
        {
            get
            {
                double[] sides = new double[3] { a, b, c };
                var sortSides = sides.OrderBy(v => v).Select(v => Math.Pow(v, 2));
                return sortSides.Max() == sortSides.ElementAt(0) + sortSides.ElementAt(1) ? true : false;
            }
        }

        public bool IsExist()
        {
            double[] sides = new double[3] { a, b, c };
            if (a + b > c && a + c > b && b + c > a && sides.All(v => v > 0))
            {
                return true;
            } else
            {
                throw new ArgumentException();
            }
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            IsExist();
        }
    }
}
