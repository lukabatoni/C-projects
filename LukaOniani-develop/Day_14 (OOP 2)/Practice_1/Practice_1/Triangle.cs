using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Triangle : Shape
    {
        public Point A { get; }

        public Point B { get; }

        public Point C { get; }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }   

        public override double FindArea()
        {
            double area = 0.5 * Math.Abs((A.X * (B.Y - C.Y)) +
                                         (B.X * (C.Y - A.Y)) +
                                         (C.X * (A.Y - B.Y)));
            return area;

        }

        public override double FindPerimeter()
        {
            double AB = Point.CalculateDistance(A, B);
            double BC = Point.CalculateDistance(B, C);
            double CA = Point.CalculateDistance(C, A);

            double perimeter = AB + BC + CA;
            return perimeter;

        }
    }
}
