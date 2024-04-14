using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public static class StringExtension
    {

        public static string StringReverse(this string s)
        {
            string res = "";
            char[] arr = s.ToCharArray();
            foreach (char c in arr) 
            {
                res = c + res;
            }
            return res;       
        }

        public static int CountChar(this string s, char c)
        {
            int counter = 0;
            char[] arr = s.ToCharArray();
            foreach (char a in arr )
            {
                if (a == c) counter++;
            }
            return counter;
        }

        public static bool CheckPrefixSufix(this string s, string substring)
        {
            int subSize = substring.Length;
            int strSize = s.Length;
            int counterPrefix = 0;
            int counterSufix = 0;
            for (int i = 0; i < subSize; i++)
            {
                if (s[i] == substring[i]) counterPrefix++;
            }
            if (counterPrefix == subSize)
            {
                return true;
            }

            for (int j = strSize - subSize, k = 0 ; j < strSize && k < subSize; j++, k++)
            {
                if (s[j] == substring[k]) counterSufix++;
            }
            if (counterSufix == subSize)
            {
                return true;
            }

            return false;
        }
        
    }
}
