int CountRec(int i)
{
    if (i == 0)
        return 1; 
    if (i < 10)
        return 1; 
    return 1 + CountRec(i / 10);
}

Console.WriteLine(CountRec(0));