using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Neighbors { get; set; } = new List<Node>();
        public bool Visited { get; set; } = false;


        public Node(int value)
        {
            Value = value;
        }
    }
}
