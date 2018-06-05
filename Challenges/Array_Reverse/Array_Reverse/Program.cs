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

        static int[] ArrayReverse(int[] arr)
        {
            int n = arr.Length;
            int[] newArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                newArr[i] = arr[n - (i + 1)];
            }
            return newArr;
        }

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
