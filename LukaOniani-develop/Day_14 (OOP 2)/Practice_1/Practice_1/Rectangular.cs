using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Rectangular : IShape
    {
        public Point A { get; }

        public Point B { get; }

        public Point C { get; }

        public Point D { get; }

        public Rectangular(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public double FindArea()
        {
            double AB = Point.CalculateDistance(A, B);
            double BC = Point.CalculateDistance(B, C);
            return AB * BC;

        }

        public double FindPerimeter()
        {
            double AB = Point.CalculateDistance(A, B);
            double BC = Point.CalculateDistance(B, C);
            double perimeter = (AB + BC) * 2;
            return perimeter;

        }

    }
}
