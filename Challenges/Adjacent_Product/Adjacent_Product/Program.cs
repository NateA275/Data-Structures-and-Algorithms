using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adjacent_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = new int[,] {{ 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }};
            PrintArray(array2d);
            PrintArray(RotateArray(array2d));
            Console.ReadLine();
        }



        public static int[,] RotateArray(int[,] array)
        {
            int[,] newArray = new int[array.Length, array[0].Length];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {


                }
            }

            return newArray;
        }



        public static void PrintArray(int[,] array)
        {
            Console.WriteLine("Rows: " + array.Length);
            Console.WriteLine("Cols: " + array[0].Length);

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
