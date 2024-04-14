Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int temp;
int[] numbers = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Enter number for index " + i + ": ");
    temp = Convert.ToInt32(Console.ReadLine());
    numbers[i] = temp;
}
Console.WriteLine("Here is your reversed array!");
for (int j = size-1; j >= 0; j--)
{
    Console.WriteLine(numbers[j]);
}