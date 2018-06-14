using System;
using LinkedLists.Classes;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list1 = new MyLinkedList(new Node(1));
            MyLinkedList list2 = new MyLinkedList(new Node(5));
            
            list1.AddLast(new Node(2));
            list2.AddLast(new Node(10));
            list2.AddLast(new Node(15));
            list2.AddLast(new Node(20));
            list1.Merge(list1, list2);

            list1.Print();

            Console.ReadLine();
        }
    }
}
