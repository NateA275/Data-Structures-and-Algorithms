using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        public List<Node> AllNodes { get; set; } = new List<Node>();


        public Graph(Node node)
        {
            AllNodes.Add(node);
        }

        //Adds new Vertice to graph
        public void AddEdge(Node firstNode, Node secondNode)
        {
            if (!AllNodes.Contains(firstNode))
                AllNodes.Add(firstNode);

            if (!AllNodes.Contains(secondNode))
                AllNodes.Add(secondNode);

            firstNode.Neighbors.Add(secondNode);
            secondNode.Neighbors.Add(firstNode);
        }


        //Returns all of the nodes in the graph as a collection
        public List<Node> GetNodes()
        {
            return AllNodes;
        }


        //Returns a collection of nodes connected to the given node
        public List<Node> GetNeighbors(Node existingNode)
        {
            return AllNodes.Contains(existingNode) ? existingNode.Neighbors : null;
        }   


        //Returns the total number of nodes in the graph
        public int Size()
        {
            return AllNodes.Count;
        }


        //Takes in a root node and returns a collection of all the nodes visited in order
        public IEnumerable<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            root.Visited = true;

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node neighbor in front.Neighbors)
                {
                    if (!neighbor.Visited)
                    {
                        neighbor.Visited = true;
                        breadth.Enqueue(neighbor);
                    }
                }
            }

            return order;
        }
    }
}
