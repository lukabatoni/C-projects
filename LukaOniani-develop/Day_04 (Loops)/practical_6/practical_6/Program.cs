Console.Write("enter a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());
string res = "";
for (int i = 1; i <= num; i++)
{
    if (num % i == 0 && i != num)
    {
        res += (i + ",");
    }
    else if (num % i == 0)
    {
        res += i;
    }
}
Console.WriteLine("divisors of " + num + " are: " + res);