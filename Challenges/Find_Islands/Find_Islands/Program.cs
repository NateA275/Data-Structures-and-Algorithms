using System;
using System.Collections.Generic;

namespace Find_Islands
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[,]
                {
                    {0, 1, 0, 0, 0},
                    {1, 0, 0, 0, 0},
                    {0, 0, 0, 1, 0},
                    {0, 0, 1, 0, 0},
                    {0, 0, 0, 0, 0}
                };

            Console.WriteLine(FindIslands(matrix));
            Console.ReadLine();
        }

        /// <summary>
        /// FindIslands - Method takes a two dimentional Array which represents an Adjacency Matrix and returns the number 
        /// of "islands" it contains (isolated groups of connected elements).
        /// </summary>
        /// <param name="matrix"> int[,] - Two dimensional matrix representing connections between graph elements </param>
        /// <returns>  int - number of seperated "islands" </returns>
        public static int FindIslands(int[,] graphMatrix)
        {
            int islandCounter = 0;
            List<int> searchedNodes = new List<int>();

            for (int i = 0; i < graphMatrix.GetLength(0); i++)
            {
                bool nodeIsIsland = true;

                for (int j = 0; j < graphMatrix.GetLength(1); j++)
                {
                    if (graphMatrix[i, j] > 0)
                    {
                        nodeIsIsland = false;

                        if (!searchedNodes.Contains(j))
                        {
                            searchedNodes.Add(j);
                            islandCounter++;
                        }
                        break;
                    }
                }

                if (nodeIsIsland)
                    islandCounter++;

                searchedNodes.Add(i);
            }

            return islandCounter;
        }
    }
}
