Console.Write("enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
string res = "";
for (int i = 1; i <= num; i++)
{
    if(i % 2 == 1)
    {
        for (int j = 1; j <= i; j++)
        {
            if (j % 2 == 1) res += "1 ";
            else res += "0 "; 
        }
    }
    else
    {
        for (int j = 1; j <= i; j++)
        {
            if (j % 2 == 1) res += "0 ";
            else res += "1 ";
        }
    }
    Console.WriteLine(res);
    res = "";
}
