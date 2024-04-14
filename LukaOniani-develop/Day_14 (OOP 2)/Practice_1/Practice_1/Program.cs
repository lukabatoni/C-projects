namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //აბსტრაქტ კლასის მაგალითი არის გამოყენებული კლასს Triangle და Circle
            //ინტერფეისი გამოყენებულია rectangular-ზე, ცალ-ცალკე ყველასთვის აღარ შევცვალე რადგან იგივე იქნებოდა
            

            Console.WriteLine("For Triangle Functions:");

            Console.WriteLine("Enter coordinates for point a: ");
            double ta1 = Convert.ToDouble(Console.ReadLine());
            double ta2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for point b: ");
            double tb1 = Convert.ToDouble(Console.ReadLine());
            double tb2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for point c: ");
            double tc1 = Convert.ToDouble(Console.ReadLine());
            double tc2 = Convert.ToDouble(Console.ReadLine());

            Point Ta = new Point(ta1, ta2);
            Point Tb = new Point(tb1, tb2);
            Point Tc = new Point(tc1, tc2);

            Triangle triangle = new Triangle(Ta, Tb, Tc);

            Console.WriteLine();

            Console.WriteLine("For Rectangle Functions:");

            Console.WriteLine("Enter coordinates for point a: ");
            double ra1 = Convert.ToDouble(Console.ReadLine());
            double ra2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for point b: ");
            double rb1 = Convert.ToDouble(Console.ReadLine());
            double rb2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for point c: ");
            double rc1 = Convert.ToDouble(Console.ReadLine());
            double rc2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for point d: ");
            double rd1 = Convert.ToDouble(Console.ReadLine());
            double rd2 = Convert.ToDouble(Console.ReadLine());

            Point Ra = new Point(ra1, ra2);
            Point Rb = new Point(rb1, rb2);
            Point Rc = new Point(rc1, rc2);
            Point Rd = new Point(rd1, rd2);

            Rectangular rectangle = new Rectangular(Ra, Rb, Rc, Rd);

            Console.WriteLine();


            Console.WriteLine("For Circle Functions:");

            Console.WriteLine("Enter coordinates for point center: ");
            double centerA1 = Convert.ToDouble(Console.ReadLine());
            double centerA2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for point onCircle: ");
            double onCirclea1 = Convert.ToDouble(Console.ReadLine());
            double onCirclea2 = Convert.ToDouble(Console.ReadLine());

            Point Center = new Point(centerA1, centerA2);
            Point Oncircle = new Point(onCirclea1, onCirclea2);

            Circle circle = new Circle(Center, Oncircle);

            //რადგანაც მხოლოდ rectangle აიმპლემენტირებს ინტერფეისს გამოვიდა 1 ელემენტიანი მასივი
            //დანარჩენი 2 რომლებიც დავსვით აბსტრაქტ კლასზე - იქნება 2 ელემენიტანი მასივი- იმავე პრინციპით

            IShape[] shapes = new IShape[1] {rectangle};

            foreach (var shape in shapes)
            {
                if (shape is Rectangular)
                {
                    Console.WriteLine("Rectangle Functions:");    
                }
                Console.WriteLine($"Area: {shape.FindArea()}");
                Console.WriteLine($"Perimeter: {shape.FindPerimeter()}");
                Console.WriteLine();
            }

            Shape[] obj = new Shape[2] { triangle,  circle };

            foreach (var shape in obj)
            {
                if (shape is Triangle)
                {
                    Console.WriteLine("Triangle Functions:");
                }
                else if (shape is Circle)
                {
                    Console.WriteLine("Circle Functions:");
                }

                Console.WriteLine($"Area: {shape.FindArea()}");
                Console.WriteLine($"Perimeter: {shape.FindPerimeter()}");
                Console.WriteLine();
            }

        }
    }
}
