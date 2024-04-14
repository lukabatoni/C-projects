namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            Console.WriteLine("Choose One Of Them With Suitable 1)Start Test or  2)Add Test ");
            Console.Write("Choose 1 or 2: ");
            string input = Console.ReadLine();
            string path = @"C:\Users\lukaa\Desktop\New folder (2)\Day_21 (Reflection, GC, Attribute)\Tests.txt";
            var questions = File.ReadAllLines(path);

            if (input == "1")
            {
                int score = 0;
                foreach (var question in questions)
                {
                    try
                    {
                        string answer = "";
                        var splitedQuestion = question.Split("|");
                        foreach (var el in splitedQuestion)
                        {
                            if (el[el.Length - 1] == '*')
                            {
                                Console.WriteLine(el.Substring(0, el.Length - 1));
                                answer = el.Substring(0, 1);
                            }
                            else
                            {
                                Console.WriteLine(el);
                            }

                        }
                        Console.Write("Choose answer: a, b, c, or d: Your answer: ");
                        string inputAnswer = Console.ReadLine();
                        if (inputAnswer == answer) { score++; }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                }

                Console.WriteLine($"your result is: {score}/{questions.Length}");

            }
            if (input == "2")
            {
                Console.WriteLine("Enter question: ");
                string inputQuestion = Console.ReadLine();
                Console.WriteLine("Now Enter 4 answers. If the correct answer, mark it with '*' symbol at the end.");
                Console.Write("Enter answer1: ");
                string answer1 = Console.ReadLine();
                Console.Write("Enter answer2: ");
                string answer2 = Console.ReadLine();
                Console.Write("Enter answer3: ");
                string answer3 = Console.ReadLine();
                Console.Write("Enter answer4: ");
                string answer4 = Console.ReadLine();
                string completeQuestion = $"{questions.Length + 1}){inputQuestion}|a){answer1}|b){answer2}|c){answer3}|d){answer4}";

                try
                {
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        
                        writer.WriteLine(completeQuestion);
                    }

                    Console.WriteLine("Content has been added to the file successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
