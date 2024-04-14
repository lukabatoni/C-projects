using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Man
    {
        public Man(string word)
        {
            Word = word;
            Count = 6;
        }

        public string Word { get; set; }
        public int Count { get; set; }

        public string Res { get; set; }

        public void displayWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Res += "_";
            }
            Console.WriteLine(Res);
        }

        public void decreaseHealth()
        {
            Count--;
            switch (Count)
            {
                case 5: Console.WriteLine("Head removed");
                    break;
                case 4: Console.WriteLine("Body Removed");
                    break;
                case 3:
                    Console.WriteLine("1 Arm Removed");
                    break;
                case 2:
                    Console.WriteLine("2 Arms Removed");
                    break;
                case 1:
                    Console.WriteLine("1 Leg Removed");
                    break;
            }
            Console.WriteLine("Health left: " + Count);
            if (Count == 0)
            {
                Console.WriteLine("Game Over");
            }
        }

        public bool IsAlive()
        {
            return Count > 0;
        }

        public void ShowLetter(string word, char letter)
        {
            StringBuilder result = new StringBuilder(Res);
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    result[i] = letter;
                }
            }

            Res = result.ToString();
            Console.WriteLine(Res);
        }

    }


}
