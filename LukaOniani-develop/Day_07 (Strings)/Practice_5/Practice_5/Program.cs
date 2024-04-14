using System;

class Program
{
    static void Main(string[] args)
    {
        string original = "Hello 1 !";
        int countNumbers = CountNumbers(original);
        int countLetters = CountLetters(original);
        PrintResult(countLetters, countNumbers, original);
    }


    static int CountNumbers(string value)
    {
        int count = 0;
        foreach (char c in value)
        {
            if (char.IsDigit(c))
                count++;
        }
        return count;
    }

    static int CountLetters(string value)
    {
        int count = 0;
        foreach (char c in value)
        {
            if (char.IsLetter(c))
                count++;
        }
        return count;
    }

    static void PrintResult(int letter, int number, string value)
    {
        int others = value.Length - (letter + number);
        Console.WriteLine("\"" + value + "\" -> Letters: " + letter + ", Numbers: " + number + ", Others: " + others);
    }

}