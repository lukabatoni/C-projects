int Power(int num, int degree)
{
    if (degree == 0)
        return 1;
    else
        return num * Power(num, degree - 1);
}

