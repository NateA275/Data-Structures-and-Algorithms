# Find Intersection

This challenge is an exercise in utilizing Hashtables and Hashsets to hash and
store data in an efficient way.

## Challenge

Write a function called tree_intersection that takes two binary tree parameters.
Without utilizing any of the built-in library methods available to your language,
return a set of values found in both trees.


## Whiteboard

![queue_with_stacks](../../assets/Find_Intersection.jpg)

## Code
```C#
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
```
