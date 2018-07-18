using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Intersection.Classes
{
    public class Hashset
    {
        public Node[] Set { get; set; } = new Node[1024];
        public int Count { get; set; }

        /// <summary>
        /// Add - Adds a node to a Node Array.
        /// </summary>
        /// <param name="key"></param>
        /// <returns> boolean - True if node was added, false if node was not added </returns>
        public bool Add(Node node)
        {
            int index = node.Value * 599 / 1024;

            if (Set[index] == null)
            {
                Set[index] = node;
                Count++;
                return true;
            }

            return false;
        }
    }
}
