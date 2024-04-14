Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 1;
int k = 1;
int temp = 0;
string res = "";
if(num > 1)
{
    res = "0, 1, ";
    while (k != num)
    {
        temp = i + j;
        if (k == num - 1) res += temp;
        else
        {
            res += temp + ", ";
        }

        i = j;
        j = temp;
        k++;
    }
    Console.WriteLine(res);
}
else if(num == 1)
{
    Console.WriteLine("0, 1");
}
else
{
    Console.WriteLine("0");
}
