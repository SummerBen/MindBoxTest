using FiguresLibrary.models;

namespace SquareApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figure1 = new Figure(3, 4, 5);
            var figure2 = new Figure(4);
            Console.WriteLine($"{figure1.whichFigure} square = {figure1.square}");
            Console.WriteLine($"{figure2.whichFigure} square = {figure2.square}");
        }
    }
}