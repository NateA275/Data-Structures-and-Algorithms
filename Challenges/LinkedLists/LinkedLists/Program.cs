using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            MyLinkedList ll = new MyLinkedList(n1);

            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            ll.AddLast(n2);
            ll.AddLast(n3);
            ll.AddLast(n4);
            ll.AddLast(n5);

            Console.WriteLine(ll.KthElement(7).Value);

            ll.Print();

            Console.ReadLine();
        }
    }
}
