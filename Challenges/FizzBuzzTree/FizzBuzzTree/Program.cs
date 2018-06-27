using FizzBuzzTree.Classes;
using System;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node("Root");

            string[] values = new string[] { "Node", "Node", "45", "17", "10", "Node", "12", "0", null, "12.5" };

            foreach (string val in values)
                bt.Add(rootNode, new Node(val));

            Console.WriteLine("--Before FizzBuzz--");
            bt.BreadthFirst(rootNode);
            Console.WriteLine();


            Console.WriteLine("--After FizzBuzz--");
            bt.FizzBuzzTree(rootNode);
            bt.BreadthFirst(rootNode);

            Console.ReadLine();
        }
    }
}
