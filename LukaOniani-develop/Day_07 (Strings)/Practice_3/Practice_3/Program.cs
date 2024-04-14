void AddSpaces(string value)
{
    char[] chars = value.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        Console.Write(chars[i]);
        if (i < chars.Length - 1) 
        {
            Console.Write(" ");
        }
    }
}

