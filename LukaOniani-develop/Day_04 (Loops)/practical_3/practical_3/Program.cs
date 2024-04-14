Console.Write("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    Console.WriteLine(i + " cubbed is " + i*i*i);
}