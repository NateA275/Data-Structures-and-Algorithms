using System;
using System.Collections.Generic;
using System.Text;

namespace Multi_Bracket_Validation.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        //Constructors
        public Stack()
        {
            Top = null;
        }

        public Stack(Node node)
        {
            Top = node;
        }


        /// <summary>
        /// Push - Adds node to the top of stack
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }


        /// <summary>
        /// Pop - Removes node from top and returns it
        /// </summary>
        /// <returns> Node - the top node of stack </returns>
        public Node Pop()
        {
            try
            {
                Node temp = Top;
                Top = Top.Next;
                return temp;
            }
            catch (Exception)
            {
                throw new Exception("Stack is Empty.");
            }
        }
    }
}
