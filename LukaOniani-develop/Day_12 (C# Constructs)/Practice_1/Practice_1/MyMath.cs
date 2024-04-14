using System;

namespace Practice_1
{
    public static class MyMath
    {
        public enum Statuses
        {
            PowMustBeaPositiveOrZero,
            Success,
            Num1LessThanNum2,
            Num2LessThanNum1,
            Num1GreaterThanNum2,
            Num2GreaterThanNum1,
            NumbersEqual,
        }

        public static double Pow(double number, int degree, out Statuses status)
        {
            if (degree < 0)
            {
                status = Statuses.PowMustBeaPositiveOrZero;
                return 0;
            }

            double res = 1;
            for (int i = 0; i < degree; i++)
            {
                res *= number;
            }

            status = Statuses.Success;
            return res;
        }

        public static int FindMin(int a, int b, out Statuses status)
        {
            if(a < b)
            {
                status = Statuses.Num1LessThanNum2;
                return a;
            }
            else if(a > b) 
            {
                status = Statuses.Num2LessThanNum1;
                return b;
            }
            else
            {
                status = Statuses.NumbersEqual;
                return -1;
            }
        }

        public static int FindMax(int a, int b, out Statuses status)
        {
            if(a > b)
            {
                status = Statuses.Num1GreaterThanNum2;
                return a;
            }
            else if (a < b)
            {
                status = Statuses.Num2GreaterThanNum1;
                return b;
            }
             else
            {
                status = Statuses.NumbersEqual;
                return -1;
            }
        }
    }
}
