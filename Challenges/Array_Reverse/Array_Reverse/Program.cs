using System;

namespace Array_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[]{ 1, 2, 3, 4, 5};
            Console.WriteLine(ArrayToString(ArrayReverse(myArr)));
            Console.ReadLine();
        }

        /*
         * ArrayReverse method - reverses the order of elements within an array
         * @param integer array arr - array of integers of any length
         * @return integer array newArr - resultant reversed array of integers
         */
        static int[] ArrayReverse(int[] arr)
        {
            int n = arr.Length; //Set variable for length, since it is used often.
            int[] newArr = new int[n]; //Declare new integer array to hold solution
            for (int i = 0; i < n; i++)
            {
                newArr[i] = arr[n - (i + 1)]; //Assign values to new array
            }
            return newArr; //Return the resultant
        }

        /*
         * ArrayToString method - Presents array in an easily read foramt
         * @param integer array arr - input array to be displayed
         * @return string str - array in visual format
         */
        static string ArrayToString(int[] arr)
        {
            string str = "[";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                str += (arr[i] + ", ");
            }
            str += (arr[arr.Length - 1] + "]");
            return str;
        }
    }
}
