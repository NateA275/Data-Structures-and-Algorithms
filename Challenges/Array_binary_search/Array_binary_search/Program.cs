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


        /* BinarySearch method - Utilizes binary search to find the index of a value within a sorted array
         * @param integer array arr - Sorted array of integers to be searched
         * @param integer key - Value to be found within sorted array
         * @return intger - Index of selected value within array or -1 if value DNE
         */ 
        static int BinarySearch(int[] arr, int key)
        {
            int left = 0; //Delcare left post index
            int right = arr.Length - 1; //Declare right post index

            while (left <= right)
            {
                int middle = (left + right) / 2; //Declare middle value index
                if (arr[middle] == key) //Evaluate middle value
                    return middle; //Return Index

                if (arr[middle] > key)
                    right = middle - 1; //Reassign right post

                if (arr[middle] < key)
                    left = middle + 1; //Reassign left post
            }

            return -1; //Return -1 if not found

        }
    }
}
