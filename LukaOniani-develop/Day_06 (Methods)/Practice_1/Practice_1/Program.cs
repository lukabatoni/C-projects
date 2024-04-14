string GetElement(int[] arr, int index)
{
    if (index >= arr.Length || index < 0)
        return "index out of bound";
    return "Number at index " + index + " in the array is " + arr[index];
}
