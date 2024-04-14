Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = 0;
string res = "";

while (Math.Pow(2, n) <= num)
{
    n++;
}

while (num > 0)
{
    n--;

    if (num - Math.Pow(2, n) >= 0)
    {
        res += "1";
        num -= Convert.ToInt32(Math.Pow(2, n));
    }
    else
    {
        res += "0";
    }
}

Console.WriteLine(res);
Console.ReadKey();