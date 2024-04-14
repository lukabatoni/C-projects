string ReverseString(string value)
{
    char[] charArray = value.ToCharArray();
    Array.Reverse(charArray);

    return new string(charArray);
}

Console.WriteLine(ReverseString("Hello"));