using FiguresLibrary.interfaces;

namespace FiguresLibrary.models
{
    public class Figure : IFigure
    {
        IFigure _figure;

        public double square
        {
            get
            {
                return _figure.square;
            }
            set
            {
                square = value;
            }
        }

        public string whichFigure;

        public Figure(double radius)
        {
            _figure = new Circle(radius);
            whichFigure = "Circle";
        }

        public Figure(double a, double b, double c)
        {
            _figure = new Triangle(a, b, c);
            whichFigure = (_figure as Triangle).isRectangular ? "Rectangular triangle" : "Regular triangle";
        }
    }
}
