using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks.Classes
{
    public class MyStack
    {
        public Node Top { get; set; }


        public MyStack(Node node)
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
            Node temp = Top;
            Top = Top.Next;
            return temp;
        }


        /// <summary>
        /// Peek - Returns the value of the top node without altering stack
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return Top.Value;
        }


        /// <summary>
        /// Print - Displays stack data in a legible format
        /// </summary>
        public void Print()
        {
            Node Current = Top;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} => ");
                Current = Current.Next;
            }
            Console.Write(Current.Value);
        }
    }
}