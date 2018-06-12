using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node n5 = new Node(5);
            MyLinkedList ll = new MyLinkedList(n5);

            Node n4 = new Node(4);
            Node n3 = new Node(3);
            Node n2 = new Node(2);

            ll.Add(n4);
            ll.Add(n3);
            ll.Add(n2);

            Node n6 = new Node(6);
            ll.AddAfter(n6, n5);

            Node n1 = new Node(1);
            ll.AddBefore(n1, n2);

            Console.WriteLine(ll.Find(5).Value);


            ll.Print();

            Console.ReadLine();
        }
    }
}
