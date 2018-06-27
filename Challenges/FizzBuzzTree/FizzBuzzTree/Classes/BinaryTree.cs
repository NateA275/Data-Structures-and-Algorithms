using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class BinaryTree
    {
        /// <summary>
        /// PreOrder - Tree Traversal where root is examined first, then left child, and finally right child.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        public void PreOrder(Node root)
        {
            Console.WriteLine(root.Value);

            if (root.LeftChild != null)
                PreOrder(root.LeftChild);

            if (root.RightChild != null)
                PreOrder(root.RightChild);
        }

        /// <summary>
        /// InOrder - Tree Traversal where left child is examined first, then root, and finally right child.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        public void InOrder(Node root)
        {
            if (root.LeftChild != null)
                InOrder(root.LeftChild);

            Console.WriteLine(root.Value);

            if (root.RightChild != null)
                InOrder(root.RightChild);
        }

        /// <summary>
        /// PostOrder - Tree Traversal where left child is examined first, then right child, and finally root.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        public void PostOrder(Node root)
        {
            if (root.LeftChild != null)
                PostOrder(root.LeftChild);

            if (root.RightChild != null)
                PostOrder(root.RightChild);

            Console.WriteLine(root.Value);
        }

        /// <summary>
        /// BreadthFirst - Tree traversal using Queue to explore neighbor nodes before deeper nodes.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                Console.WriteLine(front.Value);

                if (front.LeftChild != null)
                    breadth.Enqueue(front.LeftChild);

                if (front.RightChild != null)
                    breadth.Enqueue(front.RightChild);
            }
        }

        /// <summary>
        /// Add - Inserts a node into the first open spot within the tree.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        /// <param name="newNode"> Node - Node to be added to tree </param>
        public void Add(Node root, Node newNode)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.LeftChild == null)
                {
                    front.LeftChild = newNode;
                    return;
                }

                if (front.RightChild == null)
                {
                    front.RightChild = newNode;
                    return;
                }

                if (front.LeftChild != null)
                    breadth.Enqueue(front.LeftChild);

                if (front.RightChild != null)
                    breadth.Enqueue(front.RightChild);
            }
        }

        /// <summary>
        /// Search - Uses breadth first to search for Nodes before proceeding to use depth.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        /// <param name="value"> int - Value being searched for </param>
        /// <returns></returns>
        public Node Search(Node root, int value)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.Value.Equals(value))
                    return front;

                if (front.LeftChild != null)
                    breadth.Enqueue(front.LeftChild);

                if (front.RightChild != null)
                    breadth.Enqueue(front.RightChild);
            }
            return null;
        }

        /// <summary>
        /// FizzBuzzTree - Changes Node values within the tree based on traditional FizzBuzz rules.
        /// </summary>
        /// <param name="root"> Node - Root Node of Binary Tree </param>
        /// <returns> Node - Root Value of Binary Tree </returns>
        public Node FizzBuzzTree(Node root)
        {
            int number;
            bool isNum = Int32.TryParse(root.Value, out number);

            if (isNum && number != 0)
            {
                if (number % 15 == 0)
                    root.Value = "FizzBuzz";
                else if (number % 5 == 0)
                    root.Value = "Buzz";
                else if (number % 3 == 0)
                    root.Value = "Fizz";
            }

            if (root.LeftChild != null)
                FizzBuzzTree(root.LeftChild);

            if (root.RightChild != null)
                FizzBuzzTree(root.RightChild);

            return root;
        }
    }
}
