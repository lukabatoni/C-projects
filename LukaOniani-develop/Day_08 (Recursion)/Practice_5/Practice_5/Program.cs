bool PalindromeCheck(string word)
{
    Console.WriteLine(word);
    int size = word.Length;
    if (size == 0 || size == 1)
        return true;
    else
    {
        if (word[0] == word[size - 1])
            return PalindromeCheck(word.Substring(1, size - 2));
        else
            return false;
    }
}
Console.WriteLine(PalindromeCheck("ababa"));