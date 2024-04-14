namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test1
            //Console.WriteLine(CheckBalance("{}(())[](([]))"));

            //Test2
            //Tuple<double, double> t1 = new Tuple<double, double>(7.0, -5.0);
            //Tuple<double, double> t2 = new Tuple<double, double>(7.0, 0.0);
            //Console.WriteLine(CalcDistance(t1, t2));


            //Test 3
            //int num1 = 5;
            //int num2 = 3;
            //int resultSum, resultFactorial;
            //CalculateSumAndFactorial(num1, num2, out resultSum, out resultFactorial);
            //Console.WriteLine($"Sum: {resultSum}, Factorial of {num2}: {resultFactorial}");

            //Console.WriteLine("Same with Tuple");
            //int tup1 = 5;
            //int tup2 = 3;
            //Tuple<int, int> result = CalculateSumAndFactorialTuple(tup1, tup2);
            //Console.WriteLine($"Sum: {result.Item1}, Factorial of {tup2}: {result.Item2}");


            //Test 4
            //List<Book> books = new List<Book>
            //{
            //    new Book("Stendhal", "The Red and the Black", 1830, "9780140447644", Genre.Fiction),
            //    new Book("Franz Kafka", "The Metamorphosis", 1915, "9780141187996", Genre.Mystery),
            //    new Book("Jane Austen", "Pride and Prejudice", 1813, "9780141439518", Genre.Romance)
            //};

            ////sort by genre
            //books.Sort(new GenreComparer());
            //Console.WriteLine("Sorted by Genre:");
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"{book.Title} - {book.BookGenre}");
            //}

            //Console.WriteLine();

            ////sort by fullname
            //books.Sort(new AuthorComparer());
            //Console.WriteLine("Sorted by Fullname:");
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"{book.Title} - {book.AuthorFullName}");
            //}

            //Console.WriteLine();

            //sort by year
            //books.Sort(new YearComparer());
            //Console.WriteLine("Sorted by ProductYear:");
            //foreach (var book in books)
            //{
            //    Console.WriteLine($"{book.Title} - {book.ProductionYear}");
            //}

            //Console.ReadKey();
        }


        static bool CheckBalance(string input)
        {
            Stack<char> stack = new();

            Dictionary<char, char> dict = new();
            dict.Add('(', ')');
            dict.Add('{', '}');
            dict.Add('[', ']');

            for (int i = 0; i < input.Length; i++)
            {
                if (dict.Keys.Contains(input[i]))
                    stack.Push(input[i]);
                else if (stack.Count > 0 && input[i] == dict[stack.Peek()])
                    stack.Pop();
                else
                    return false;
            }

            return stack.Count == 0;
        }


        static double CalcDistance(Tuple<double, double> t1, Tuple<double, double> t2)
        {
            double distance = Math.Sqrt(Math.Pow(t2.Item1 - t1.Item1, 2) + Math.Pow(t2.Item2 - t1.Item2, 2));
            return distance;
        }


        public static void CalculateSumAndFactorial(int a, int b, out int sum, out int factorial)
        {
            sum = a + b;

            factorial = 1;
            for (int i = 1; i <= b; i++)
            {
                factorial *= i;
            }
        }

        public static Tuple<int, int> CalculateSumAndFactorialTuple(int a, int b)
        {
            int sum = a + b;

            int factorial = 1;
            for (int i = 1; i <= b; i++)
            {
                factorial *= i;
            }

            Tuple<int, int> res = new Tuple<int, int>(sum, factorial);
            return res;
        }
    
    }
}
