using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            MyQueue queue1 = new MyQueue(firstNode);
            queue1.Enqueue(secondNode);
            queue1.Enqueue(thirdNode);
            queue1.Print();

            Console.WriteLine("\n-------------");


            MyStack stack1 = new MyStack(new Node(1));
            stack1.Push(new Node(2));
            stack1.Push(new Node(3));
            stack1.Print();

            Console.ReadLine();
        }
    }
}
