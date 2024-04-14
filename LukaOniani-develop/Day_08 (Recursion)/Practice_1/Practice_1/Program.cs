/*void CountRec(int i)
{
    if (i > 0)
    {
        CountRec(i - 1);
        Console.Write(i + " ");
    }
}


CountRec(10);
Console.Read(); 

int sum = 0;

void CountRec(int i)
{
    if (i > 0)
    {
  

        CountRec(i - 1);
        Console.WriteLine("this is i: " + i);
        sum += i;

        Console.WriteLine(sum);
    }
}

void CountRec2(int i)
{
    if (i > 0)
    {

        Console.WriteLine("this is i: " + i);
        sum += i;
        CountRec2(i - 1);
        Console.WriteLine(sum);
    }
}

CountRec(5);
Console.WriteLine();
CountRec2(5);
Console.ReadKey();
*/

//string rev = "123";
//rev = rev.Substring(0, rev.Length-1);
//string res = "";

//string ReverseRec(string word)
//{
//    int size = word.Length;
//    if (size == 0)
//        return "";
//    res += word[size - 1];
//    word = word.Substring(0, size-1);
//    ReverseRec(word);
//    return res;
//}

//Console.WriteLine(ReverseRec("abc"));
//Console.ReadKey();
