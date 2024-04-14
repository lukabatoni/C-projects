using System.Diagnostics.Tracing;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            List<string> list = new List<string>();
            list.Add("car");
            list.Add("google");
            list.Add("computer");
            list.Add("football");

            Random r = new Random();
            string chosen = list[r.Next(0, list.Count)];

            Console.WriteLine(chosen);
            Man player = new Man(chosen);
            

            player.displayWord(chosen);
          


            while (player.IsAlive())
            {
                char guess = Convert.ToChar(Console.ReadLine());
                if(chosen.Contains(guess))
                {
                    player.ShowLetter(player.Res, guess);
                }
                else
                {
                    player.decreaseHealth();
                }

                if (player.Res == chosen)
                {
                    Console.WriteLine("You have won the game!");
                    break;
                }
                Console.ReadKey();

            }
        }
    }
}