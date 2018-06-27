using System;
using Trees.Classes;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            Node rootNode = new Node(1);
            bt.Add(rootNode, new Node(2));
            bt.Add(rootNode, new Node(3));
            bt.Add(rootNode, new Node(4));
            bt.Add(rootNode, new Node(5));

            Console.WriteLine("PreOrder: 1, 2, 4, 5, 3");
            bt.PreOrder(rootNode);

            Console.WriteLine("InOrder: 4, 2, 5, 1, 3");
            bt.InOrder(rootNode);

            Console.WriteLine("PostOrder: 4, 5, 2, 3, 1");
            bt.PostOrder(rootNode);

            Console.WriteLine("Breadth First: 1, 2, 3, 4, 5");
            bt.BreadthFirst(rootNode);

            Console.WriteLine("Press ENTER for BST Methods");
            Console.ReadLine();
            Console.Clear();

            BinarySearchTree bst = new BinarySearchTree();
            Node newRoot = new Node(10);

            bst.Add(newRoot, new Node(5));
            bst.Add(newRoot, new Node(15));
            bst.Add(newRoot, new Node(3));
            bst.Add(newRoot, new Node(17));
            bst.Add(newRoot, new Node(7));
            bst.Add(newRoot, new Node(13));

            Console.WriteLine("PreOrder: 10, 5, 3, 7, 15, 13, 17");
            bst.PreOrder(newRoot);

            Console.WriteLine("InOrder: 3, 5, 7, 10, 13, 15, 17");
            bst.InOrder(newRoot);

            Console.WriteLine("PostOrder: 3, 7, 5, 13, 17, 15, 10");
            bst.PostOrder(newRoot);

            Console.WriteLine("BreadthFirst: 10, 5, 15, 3, 7, 13, 17");
            bst.BreadthFirst(newRoot);1
            Console.ReadLine();
        }
    }
}
