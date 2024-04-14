int[] CreateArr()
{
    Console.Write("Enter size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int val;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter integer for index " + i + ":");
        val = Convert.ToInt32(Console.ReadLine());
        arr[i] = val;
    }
    return arr;
}

int GetFact(int num)
{
    int k = 1;
    int fact = 1;
    while (k <= num) 
    {
        fact *= k;
        k++;
    }
    return fact;
}

string FindFact(int[] arr, int el) 
{
    foreach (int i in arr)
    {
        if(i == el)
        {
            return "Factorial of " + el + " is " + GetFact(i);
        }
    }

    return "Number " + el + " was not found in the given array";
}


Console.WriteLine(FindFact(CreateArr(), 5));