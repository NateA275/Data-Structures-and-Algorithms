# Find Max Value in a Binary Tree

This challenge is an exersize in utilizing binary trees. Inside, a binary tree is used to traverse
though Nodes and return the largest value of all included nodes.

## Challenge

Write a function called find-maximum-value which takes binary tree as its only imput.

Without utilizing any of the built-in methods available to your language, 

return the maximum value stored in the tree. You can assume that the values stored 

in the Binary Tree will be numeric.

## Whiteboard

![FindMaxValue](../../assets/find_max_value.jpg)

## Code
```C#
        /// <summary>
        /// FindMaximumValue - Traverses a binary tree and returns the largest Node value within.
        /// </summary>
        /// <param name="root">Node - Root node of a binary tree </param>
        /// <returns>int - Maximum value contained within the tree </returns>
        public int FindMaximumValue(Node root)
        {
            int max = root.Value;
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (front.Value > max)
                    max = front.Value;

                if (front.LeftChild != null)
                    breadth.Enqueue(front.LeftChild);

                if (front.RightChild != null)
                    breadth.Enqueue(front.RightChild);
            }
            return max;
        }
```
