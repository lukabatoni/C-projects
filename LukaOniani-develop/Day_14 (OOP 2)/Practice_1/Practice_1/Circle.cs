using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Circle : Shape
    {
        public Point Center { get; }
        public Point PointOnCircle { get; }

        public Circle(Point center, Point pointOnCircle)
        {
            Center = center;
            PointOnCircle = pointOnCircle;
        }

        public override double FindPerimeter()
        {
            double radius = Point.CalculateDistance(Center, PointOnCircle);
            return Math.PI * radius * radius;
        }

        public override double FindArea()
        {
            double radius = Point.CalculateDistance(Center, PointOnCircle);
            return 2 * Math.PI * radius;
        }
    }
}
