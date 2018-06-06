using System;

namespace Array_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int testKey = 55;

            Console.WriteLine(BinarySearch(testArray, testKey));
            Console.ReadLine();
        }

        static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] == key)
                    return middle;

                if (arr[middle] > key)
                    right = middle - 1;

                if (arr[middle] < key)
                    left = middle + 1;
            }

            return -1;

        }
    }
}
