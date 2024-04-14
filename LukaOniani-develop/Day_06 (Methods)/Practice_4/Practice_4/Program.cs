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

string FindAvg(int[] arr)
{
    int sum = 0;

    foreach(int item in arr)
    {
        sum += item;
    }
    
    double avg = (double)sum / (double)arr.Length;

    return "Average is: " + avg; 
}

Console.WriteLine(FindAvg(CreateArr()));