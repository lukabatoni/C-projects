Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int temp;
int[] numbers = new int[size];
int sum = 0;
for (int i = 0; i < size; i++)
{
    Console.Write("Enter number for index " + i + ": ");
    temp = Convert.ToInt32(Console.ReadLine());
    numbers[i] = temp;
}

for (int i = 0;i < size; i++)
{
    sum += numbers[i];
}
Console.WriteLine("Sum of array elements is: " + sum);
