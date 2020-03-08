using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
    public class Circle
    {
        public Point Center { get; }
        public double Radius { get; }
        public double Square => Math.PI * Radius * Radius;

        public Circle(Point point, double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can't be less than 0");
            Center = point;
            Radius = radius;
        }

        public Circle(double x, double y, double radius)
            : this(new Point(x, y), radius) { }

        public void ShowCircle()
        {
            Console.WriteLine($"Center: ({Math.Round(Center.x, 2)};{Math.Round(Center.y, 2)})\n" +
                              $"Radius = {Math.Round(Radius, 2)}");
        }

        public Circle MoveCircle(Vector vector)
        {
            return new Circle(this.Center.x + vector.x, this.Center.y + vector.y,
                this.Radius);
        }
        public double RadiusOfDoubleCircle()
        {
            return Math.Sqrt(this.Square * 2 / Math.PI);
        }
    }
}