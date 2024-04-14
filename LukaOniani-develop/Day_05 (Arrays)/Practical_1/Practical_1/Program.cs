Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int temp;
int[] num = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Enter number for index " + i + ": ");
    temp = Convert.ToInt32(Console.ReadLine());
    numbers[i] = temp;
}
Console.WriteLine("Here is your array!");
for (int j = 0;j < num.Length; j++) 
{
    Console.WriteLine(num[j]);
}