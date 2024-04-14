Console.Write("enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;
for(int i = 0; i <= num; i++)
{
    if (i % 2 == 1) res += i;
}
Console.WriteLine("sum of odd numbers from 1 to " + num + " is " + res);