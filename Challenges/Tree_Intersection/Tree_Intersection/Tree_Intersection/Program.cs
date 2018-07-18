using System;
using System.Collections.Generic;
using Tree_Intersection.Classes;

namespace Tree_Intersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating First Tree
            BinaryTree bt1 = new BinaryTree();
            Node root1 = new Node(150);
            bt1.Add(root1, new Node(100));
            bt1.Add(root1, new Node(250));
            bt1.Add(root1, new Node(75));
            bt1.Add(root1, new Node(160));
            bt1.Add(root1, new Node(200));
            bt1.Add(root1, new Node(350));
            bt1.Add(root1, new Node(125));
            bt1.Add(root1, new Node(175));
            bt1.Add(root1, new Node(300));
            bt1.Add(root1, new Node(500));

            //Creating Second Tree
            BinaryTree bt2 = new BinaryTree();
            Node root2 = new Node(42);
            bt2.Add(root2, new Node(100));
            bt2.Add(root2, new Node(600));
            bt2.Add(root2, new Node(15));
            bt2.Add(root2, new Node(160));
            bt2.Add(root2, new Node(200));
            bt2.Add(root2, new Node(350));
            bt2.Add(root2, new Node(125));
            bt2.Add(root2, new Node(175));
            bt2.Add(root2, new Node(4));
            bt2.Add(root2, new Node(500));

            Node test1 = new Node(5);
            Node test2 = new Node(10);

            //Find Common Values
            int[] commonVals = FindIntersection(test1, test2);

            //Display
            Console.WriteLine($"[{string.Join(", ",commonVals)}]");

            Console.ReadLine();
        }

        /// <summary>
        /// FindIntersection - Finds nodes common between two binary trees. Uses Breadth-First traversal.
        /// </summary>
        /// <param name="rootOne"> Node - Root of first binary tree </param>
        /// <param name="rootTwo"> Node - Root of second binary tree </param>
        /// <returns> integer array conataining the values of all common nodes </returns>
        public static int[] FindIntersection(Node rootOne, Node rootTwo)
        {
            Hashset hs = new Hashset();
            List<int> ans = new List<int>();

            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(rootOne);
            breadth.Enqueue(rootTwo);

            while (breadth.TryPeek(out rootOne))
            {
                Node front = breadth.Dequeue();

                if (!hs.Add(front))
                    ans.Add(front.Value);

                if (front.LeftChild != null)
                    breadth.Enqueue(front.LeftChild);

                if (front.RightChild != null)
                    breadth.Enqueue(front.RightChild);
            }

            return ans.ToArray();
        }
    }
}
