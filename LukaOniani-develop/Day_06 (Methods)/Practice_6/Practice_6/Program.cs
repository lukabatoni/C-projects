using System;

class Program
{
    static void Main(string[] args)
    {
        char[] arr = CreateArr();
        Console.Write("Enter symbol to count: ");
        char symbol = Convert.ToChar(Console.ReadLine());

        int count = CountSymbol(arr, symbol);
        GetResult(count, symbol);
    }

    static char[] CreateArr()

    {
        Console.Write("Enter size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        char val;
        char[] arr = new char[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter integer for index " + i + ":");
            val = Convert.ToChar(Console.ReadLine());
            arr[i] = val;
        }
        return arr;
    }

    static int CountSymbol(char[] arr, char symbol)
    {
        int count = 0;
        foreach (char c in arr)
        {
            if (c == symbol) count++;
        }
        return count;
    }

    static void GetResult(int count, char symbol)
    {
        Console.WriteLine("'" + symbol + "' shegvxvda " + count + "-jer");
    }
}

