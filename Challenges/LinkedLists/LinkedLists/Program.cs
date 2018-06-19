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

            MyStack stack1 = new MyStack(firstNode);

            stack1.Push(secondNode);
            stack1.Push(thirdNode);

            stack1.Print();




            
            Console.ReadLine();
        }
    }
}
