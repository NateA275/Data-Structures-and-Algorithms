using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Bracket_Validation.Classes
{
    public class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }


        //Constructor
        public Node(char value)
        {
            Value = value;
            Next = null;
        }
    }
}