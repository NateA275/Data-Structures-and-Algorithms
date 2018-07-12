using System;
using System.Collections.Generic;
using System.Text;

namespace Queue.Classes
{
    public class MyQueue
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }


        public MyQueue(Node node)
        {
            Head = Tail = node;
        }

        /// <summary>
        /// Enque - Adds a Node to tail of the Queue
        /// </summary>
        /// <param name="node"> Node - to be added to tail </param>
        public void Enqueue(Node node)
        {
            if (Tail != null)
                Tail.Next = node;
            Tail = node;
            if (Head == null)
                Head = node;
        }


        /// <summary>
        /// Dequeue - Removes node from the head of queue
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
            Node temp = Head;
            Head = Head.Next;
            if (Head == null)
                Tail = null;
            return temp;
        }


        /// <summary>
        /// Peek - returns value of element at head of queue
        /// </summary>
        /// <returns> int - value of node at head position </returns>
        public int Peek()
        {
            if (Head != null)
                return Head.Value;
            throw new Exception("Queue is empty.");
        }


        /// <summary>
        /// Print - Displays queue in a legible format
        /// </summary>
        public void Print()
        {
            Node Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} => ");
                Current = Current.Next;
            }
            Console.Write(Current.Value);
        }
    }
}