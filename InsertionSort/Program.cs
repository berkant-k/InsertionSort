using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] theIntArray = new int[] { 2, 40, 15, 7, -1, 0, 12 };

            SortUtil<int>.PrintArray(ref theIntArray);

            var sortedInt = SortUtil<int>.InsertionSort(theIntArray);

            SortUtil<int>.PrintArray(ref sortedInt);

            string[] theStringArray = new string[] { "A", "Z", "K", "H", "P", "J" };
            SortUtil<string>.PrintArray(ref theStringArray);
            var sortedString = SortUtil<string>.InsertionSort(theStringArray);

            SortUtil<string>.PrintArray(ref sortedString);



        }
    }
}
