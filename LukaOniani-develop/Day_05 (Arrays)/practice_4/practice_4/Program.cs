Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int temp;
int[] numbers = new int[size];
int product = 1;
for (int i = 0; i < size; i++)
{
    Console.Write("Enter number for index " + i + ": ");
    temp = Convert.ToInt32(Console.ReadLine());
    numbers[i] = temp;
}

for (int i = 0; i < size; i++)
{
    product *= numbers[i];
}
Console.WriteLine("Product of array elements is: " + product);
