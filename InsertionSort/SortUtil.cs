using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InsertionSort
{
    public static class SortUtil<T> where T : IComparable
    {
        public static void PrintArray(ref T[] array)
        {
            Console.WriteLine(nameof(@array) + "-------");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static T[]  InsertionSort(in T[] A )
        {           
            T[] result=new T[A.Length];
            Array.Copy(A, result, A.Length);
            for (int j = 1; j < result.Length; j++)
            {
                T key = result[j];
                var i = j - 1;
                while (i > -1 && result[i].CompareTo(key) > 0)
                {
                    result[i + 1] = result[i];
                    i--;                  
                }
                result[i + 1] = key;

            }

            return result;

        }
    }
}
