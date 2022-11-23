using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    interface IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
double CalculateArea();
        double CalculatePerimeter();
Rectangle rectangle = new Rectangle(6, 5);
            Square square = new Square(10);
            Circle circle = new Circle(7);

            IShape[] shapes = { rectangle, square, circle };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());

            }

    }

}

