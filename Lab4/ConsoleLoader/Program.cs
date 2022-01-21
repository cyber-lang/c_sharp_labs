using Model;
using System;

namespace ConsoleLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = null;

            Console.WriteLine("Testing Sphere");
            Console.Write("Enter R: ");
            var r = double.Parse(Console.ReadLine());
            figure = new Sphere(r);
            Console.Write("V = " + figure.CalcV());
            Console.WriteLine();
            Console.WriteLine("--------------------");

            Console.WriteLine("Testing Pyramid");
            Console.Write("Enter S: ");
            var s = double.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            var h = double.Parse(Console.ReadLine());
            figure = new Pyramid(s, h);
            Console.Write("V = " + figure.CalcV());
            Console.WriteLine();
            Console.WriteLine("--------------------");

            Console.WriteLine("Testing Parallelepiped");
            Console.Write("Enter a: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            var c = double.Parse(Console.ReadLine());
            figure = new Parallelepiped(a, b, c);
            Console.Write("V = " + figure.CalcV());
            Console.WriteLine();
            Console.WriteLine("--------------------");
        }
    }
}
