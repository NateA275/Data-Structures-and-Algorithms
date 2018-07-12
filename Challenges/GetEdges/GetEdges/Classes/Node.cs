using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node
    {
        public string City { get; set; }
        public Dictionary<Node, int> Connections { get; set; } = new Dictionary<Node, int>();
        public bool Visited { get; set; } = false;


        public Node(string city)
        {
            City = city;
        }
    }
}