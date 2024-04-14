using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public static class NumericExtension
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this double number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this double number)
        {
            return number % 2 != 0;
        }

        public static int AbsoluteVal (this int value) 
        {
            if (value >= 0) return value;
            else return value * (-1);
        }

        public static double AbsoluteVal(this double value)
        {
            if (value >= 0) return value;
            else return value * (-1);
        }

        public static int NearestMultiple(this int value, int multiple)
        {
            int i = 0;
            int tempMin = 0;
            while(i*multiple < value)
            {
                tempMin = i * multiple;
                i++;
            }
            int tempMax = i * multiple;

            int absMax = AbsoluteVal(value - tempMax);
            int absMin = AbsoluteVal(value - tempMin);

            if (absMax <= absMin)
            {
                return tempMax;
            }
            else
            {
                return tempMin;
            }
        }

        public static double NearestMultiple(this double value, double multiple)
        {
            double i = 0.0;
            double tempMin = 0.0;
            while (i * multiple < value)
            {
                tempMin = i * multiple;
                i++;
            }
            double tempMax = i * multiple;

            double absMax = AbsoluteVal(value - tempMax);
            double absMin = AbsoluteVal(value - tempMin);

            if (absMax <= absMin)
            {
                return tempMax;
            }
            else
            {
                return tempMin;
            }
        }


    }
}
