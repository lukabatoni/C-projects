namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath.Statuses StatusPow;
            MyMath.Statuses StatusMin;
            MyMath.Statuses StatusMax;

            Console.Write("for Pow func input Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("for Pow func input Degree: ");
            int degree = Convert.ToInt32(Console.ReadLine());

            double res  = MyMath.Pow(number, degree, out StatusPow);

            if (StatusPow == MyMath.Statuses.PowMustBeaPositiveOrZero)
            {
                Console.WriteLine(StatusPow);
            }
            else
            {
                Console.WriteLine($"Result: {res}, {StatusPow}");
            }

            Console.Write("for Min func input Number1: ");
            int aMin = Convert.ToInt32(Console.ReadLine());

            Console.Write("for Min func input Number2: ");
            int bMin = Convert.ToInt32(Console.ReadLine());

            int min = MyMath.FindMin(aMin, bMin, out StatusMin);

            if (StatusMin == MyMath.Statuses.Num1LessThanNum2)
            {
                Console.WriteLine($"Result: {min}, {StatusMin}");
            }
            else if(StatusMin == MyMath.Statuses.Num2LessThanNum1)
            {
                Console.WriteLine($"Result: {min}, {StatusMin}");
            }
            else
            {
                Console.WriteLine($"Result: {min}, {StatusMin}");
            }


            Console.Write("for Max func input Number1: ");
            int aMax = Convert.ToInt32(Console.ReadLine());

            Console.Write("for Max func input Number2: ");
            int bMax = Convert.ToInt32(Console.ReadLine());

            int max = MyMath.FindMax(aMax, bMax, out StatusMax);

            if (StatusMax == MyMath.Statuses.Num1GreaterThanNum2)
            {
                Console.WriteLine($"Result: {max}, {StatusMax}");
            }
            else if (StatusMax == MyMath.Statuses.Num2GreaterThanNum1)
            {
                Console.WriteLine($"Result: {max}, {StatusMax}");
            }
            else
            {
                Console.WriteLine($"Result: {max}, {StatusMax}");

            }
            Console.ReadKey();
        }
    }
}
