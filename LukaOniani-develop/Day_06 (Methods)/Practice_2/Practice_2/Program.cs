string GetSumOfDigits(int[] arr, int index)
{
    if (index >= arr.Length || index < 0)
        return "index out of bound";

    int element = arr[index];
    int sum = 0;
    int digit;
    while (element > 0)
    {
        digit = element % 10;
        sum += digit;
        element /= 10;
    }

    return "The sum of the digits of a number at index " + index + " is " + sum;
}
