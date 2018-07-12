using FindMaxBinaryTree.Classes;
using System;

namespace FindMaxBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node rootNode = new Node(1);
            BinaryTree bt = new BinaryTree();

            bt.Add(rootNode, new Node(7));
            bt.Add(rootNode, new Node(5));
            bt.Add(rootNode, new Node(2));
            bt.Add(rootNode, new Node(6));
            bt.Add(rootNode, new Node(9));
            bt.Add(rootNode, new Node(5));
            bt.Add(rootNode, new Node(11));
            bt.Add(rootNode, new Node(4));

            Console.WriteLine(bt.FindMaximumValue(rootNode));


            Console.ReadLine();

        }
    }
}
