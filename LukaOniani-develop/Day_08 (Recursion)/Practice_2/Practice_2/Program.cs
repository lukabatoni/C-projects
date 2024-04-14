using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SumRec(13));
    }

    static int SumRec(int i)
    {
        if (i <= 0)
            return 0;
        return i + SumRec(i - 1);
    }
}

