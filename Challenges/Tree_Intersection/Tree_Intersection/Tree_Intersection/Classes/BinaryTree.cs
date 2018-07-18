using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Intersection.Classes
{
    public class BinaryTree
    {
        // Uses a Breadth-First approach to add a new node to a binary tree in the
        // first available spot.
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
    }
}
