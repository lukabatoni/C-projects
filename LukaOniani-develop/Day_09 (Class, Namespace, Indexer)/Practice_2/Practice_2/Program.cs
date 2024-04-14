using System;

class Triangle
{
    private double _side1, _side2, _side3;

    public double Side1 { get { return _side1; } set {  _side1 = value; } }
    public double Side2 { get { return _side2; } set { _side2 = value; } }
    public double Side3 { get { return _side3; } set { _side3 = value; } }

    public double Perimeter()
    {
        return _side1 + _side2 + _side3;
    }

    public double Area()
    {
        double s = (_side1 + _side2 + _side3) / 2.0;
        return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
    }

    public bool IsValidTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of side 1:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3:");
        double side3 = Convert.ToDouble(Console.ReadLine());


        Triangle triangle = new Triangle
        {
            Side1 = side1,
            Side2 = side2,
            Side3 = side3
        };

        if (triangle.IsValidTriangle(triangle.Side1, triangle.Side2, triangle.Side3) == false)
        {
            Console.WriteLine("It is not a valid triangle.");
        }
        else
        {
            Console.WriteLine($"Perimeter: {triangle.Perimeter()}");
            Console.WriteLine($"Area: {triangle.Area()}");
        }

        Console.ReadLine();
    }
}