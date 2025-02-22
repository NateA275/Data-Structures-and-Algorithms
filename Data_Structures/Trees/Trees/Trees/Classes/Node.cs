﻿namespace Trees.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node RightChild { get; set; }
        public Node LeftChild { get; set; }

        public Node(int value)
        {
            Value = value;
            RightChild = null;
            LeftChild = null;
        }
    }
}
