Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;
for (int i = 1; i <= num; i++)
{
    res += i;
}
Console.WriteLine("sum from 1 to " + num + " is " + res);