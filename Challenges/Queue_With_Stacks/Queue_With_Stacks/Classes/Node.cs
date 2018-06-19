using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_With_Stacks.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }


        //Constructor
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
