using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public static class DataStructureExtension
    {
        public static int[] RemoveDublicates(this int[] arr)
        {
            int j = 0;
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[j])
                {
                    j++;
                    arr[j] = arr[i];
                }
            }

            int[] uniqueElements = new int[j + 1];
            Array.Copy(arr, uniqueElements, j + 1);

            return uniqueElements;
        }

        public static double[] RemoveDublicates(this double[] arr)
        {
            int j = 0;
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[j])
                {
                    j++;
                    arr[j] = arr[i];
                }
            }

            double[] uniqueElements = new double[j + 1];
            Array.Copy(arr, uniqueElements, j + 1);

            return uniqueElements;
        }

        public static bool CheckElement(this int[] arr, int element)
        {
            foreach (int i in arr)
            {
                if (i == element) return true;
            }
            return false;
        }

        public static bool CheckElement(this double[] arr, double element)
        {
            foreach (double i in arr)
            {
                if (i == element) return true;
            }
            return false;
        }

        public static int FindMax(this int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                if (i >= max )
                {
                    max = i;
                }
            }
            return max;
        }

        public static double FindMax(this double[] arr)
        {
            double max = arr[0];
            foreach (int i in arr)
            {
                if (i >= max)
                {
                    max = i;
                }
            }
            return max;
        }


    }
}
