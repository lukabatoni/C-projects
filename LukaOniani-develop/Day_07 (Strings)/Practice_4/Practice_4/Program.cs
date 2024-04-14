int CountWords(string value)
{
    string[] words = value.Split(' ');
    return words.Length;
}

void PrintCountWords(string value)
{
    Console.WriteLine(CountWords(value));
    
}

