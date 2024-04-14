using System;

class Program
{
    static void Main(string[] args)
    {
        int num = GetNum();
        Console.WriteLine(Seperate(num));
    }

    static int GetNum()
    {
        Console.Write("Enter a positive number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static string Seperate(int number)
    {
        string numString = number.ToString();
        int size = numString.Length;
        string res = "";

        Console.Write(number + " = ");

        for (int i = 0; i < size; i++)
        {
            int digit = Convert.ToInt32(numString[i].ToString());

            if (i != size - 1)
            {
                res += (digit + " * 10^" + (size - i - 1) + " + ");
            }
            else
            {
                res += (digit + " * 10^" + (size - i - 1));
            }
        }
        return res;
    }
}


