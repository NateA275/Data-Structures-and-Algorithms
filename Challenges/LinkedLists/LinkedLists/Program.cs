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

            MyLinkedList list1 = new MyLinkedList(firstNode);

            list1.AddLast(thirdNode);

            list1.AddAfter(secondNode, firstNode);

            try
            {
                list1.KthElement(5);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            list1.Print();
            Console.ReadLine();
        }
    }
}
