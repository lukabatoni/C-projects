

int CountLetters(string word, string param = "vowel")
{
    int countVowel = 0;
    int countCons = 0;
    char[] charArray = word.ToCharArray();
    foreach (char c in charArray)
    {
        char lower = char.ToLower(c);
        if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
        {
            countVowel++;
        }
        else
        {
            countCons++;
        }
           
    }
    if (param == "vowel")
    {
        return countVowel;
    }
    if (param == "cons")
    {
        return countCons;
    }
    else
    {
        return -1;
    }
}



void PrintLetters(string word, string param = "vowel")
{
    char[] charArray = word.ToCharArray();
    if (param == "vowel")
        Console.Write("vowels: ");
    if (param == "cons")
        Console.Write("cons: ");
    foreach (char c in charArray)
    {
        char lower = char.ToLower(c);
        if (param == "vowel")
        {
            if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
            {
                Console.Write(c + " ");
            }
        }
   
        if (param == "cons")
        {
            if (lower != 'a' && lower != 'e' && lower != 'i' && lower != 'o' && lower != 'u')
            {
                Console.Write(c + " ");
            }
        }
     

    }

}

