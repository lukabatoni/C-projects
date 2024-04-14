using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public static class CollectionAndEnumExtension
    {
        public static int[] Merge(this int[] arr, int[] arr2)
        {
            int size1 = arr.Length;
            int size2 = arr2.Length;

            int[] array = new int[size1 + size2];
     
            for (int i = 0; i < size1; i++)
            {
                array[i] = arr[i];
            }
            for (int i = size1, j = 0; i < size1 + size2 && j < size2; i++, j++)
            {
                array[i] = arr2[j];
            }
            return array;
        }

        public static double[] Merge(this double[] arr, double[] arr2)
        {
            int size1 = arr.Length;
            int size2 = arr2.Length;

            double[] array = new double[size1 + size2];

            for (int i = 0; i < size1; i++)
            {
                array[i] = arr[i];
            }
            for (int i = size1, j = 0; i < size1 + size2 && j < size2; i++, j++)
            {
                array[i] = arr2[j];
            }
            return array;
        }

        public static string Seperate(this int[] arr, string separator)
        {
            StringBuilder result = new StringBuilder();
            result.Append(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                result.Append(separator);
                result.Append(arr[i]);
            }

            return result.ToString();
        }

        public static string Seperate(this double[] arr, string separator)
        {
            StringBuilder result = new StringBuilder();
            result.Append(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                result.Append(separator);
                result.Append(arr[i]);
            }

            return result.ToString();
        }

    }
}
