﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Intersection.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node(int value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
