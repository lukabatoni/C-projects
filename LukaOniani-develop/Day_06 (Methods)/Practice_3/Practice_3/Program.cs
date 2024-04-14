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

string FindMinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 1;i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];

        if (arr[i] > max)
            max = arr[i]; 
    }

    return "Maximum is " + max + " Minimum is " + min;
}

Console.WriteLine(FindMinMax(CreateArr()));