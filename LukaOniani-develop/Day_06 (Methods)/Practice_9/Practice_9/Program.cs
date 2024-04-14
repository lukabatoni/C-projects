using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 4, 15, 13, 23, 98};
        Console.WriteLine("The product of array elements is: " + GetProduct(arr));
    }
    
    static int GetProduct(params int[] arr)
    {
        int product = 1;
        foreach (int i in arr)
        {
            product *= i;
        }
        return product;
    }
}
