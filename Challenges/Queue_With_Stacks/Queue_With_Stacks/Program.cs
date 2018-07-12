using System;
using Queue_With_Stacks.Classes;

namespace Queue_With_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue firstQueue = new Queue();

            firstQueue.Enqueue(new Node(1));
            firstQueue.Enqueue(new Node(2));
            firstQueue.Enqueue(new Node(3));
            firstQueue.Enqueue(new Node(4));
            firstQueue.Enqueue(new Node(5));
            firstQueue.Enqueue(new Node(6));

            Node retrieved = firstQueue.Dequeue();

            Console.WriteLine(retrieved.Value);

            Console.ReadLine();
        }
    }
}
