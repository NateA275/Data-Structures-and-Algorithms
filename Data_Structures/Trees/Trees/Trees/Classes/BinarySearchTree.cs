using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        /// <summary>
        /// Search - Uses a BinarySearchTree to search based on relative values.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        /// <param name="value"> int - Value to be searched for</param>
        /// <returns></returns>
        public new Node Search(Node root, int value)
        {
            Node holder = null;

            if (root.Value == value)
                return root;

            if (root.Value > value && root.LeftChild != null)
                holder = Search(root.LeftChild, value);

            if (root.Value < value && root.RightChild != null)
                holder = Search(root.RightChild, value);

            return holder;
        }

        /// <summary>
        /// Add - Uses a BinarySearchTree to add new nodes based on relative values. 
        /// Larger go to the right side of the tree, Smaller go to the left.
        /// </summary>
        /// <param name="root"> Node - Beginning root of tree </param>
        /// <param name="newNode"> Node - Node to be added to the tree </param>
        public new void Add(Node root, Node newNode)
        {
            if (newNode.Value < root.Value)
            {
                if (root.LeftChild == null)
                    root.LeftChild = newNode;

                Add(root.LeftChild, newNode);
            }

            if (newNode.Value > root.Value)
            {
                if (root.RightChild == null)
                    root.RightChild = newNode;

                Add(root.RightChild, newNode);
            }
        }
    }
}
