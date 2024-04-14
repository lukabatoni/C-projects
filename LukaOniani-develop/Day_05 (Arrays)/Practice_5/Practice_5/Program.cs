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

Console.WriteLine("Unique elements are: ");
for (int i = 0;i < size; i++)
{
    for (int j = 0; j < size; j++)
    {

        if (numbers[i] == numbers[j] && i != j)
            break;
        else if(j == size - 1)
            Console.WriteLine(numbers[i]);
    }
    
}