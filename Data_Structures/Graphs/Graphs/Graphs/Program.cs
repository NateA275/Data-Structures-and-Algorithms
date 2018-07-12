using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            Node fourthNode = new Node(4);
            Node fifthNode = new Node(5);
            Node sixthNode = new Node(6);


            Graph myGraph = new Graph(firstNode);


            myGraph.AddEdge(firstNode, secondNode);
            myGraph.AddEdge(secondNode, thirdNode);
            myGraph.AddEdge(secondNode, fourthNode);
            myGraph.AddEdge(fourthNode, fifthNode);
            myGraph.AddEdge(fourthNode, sixthNode);
            myGraph.AddEdge(secondNode, new Node(7));


            Console.WriteLine("All Nodes in Graph:");
            foreach (Node node in myGraph.GetNodes())
                Console.Write($"{node.Value} ");
            Console.WriteLine("\n");


            Console.WriteLine("All Neighbors of second node:");
            foreach (Node node in myGraph.GetNeighbors(secondNode))
                Console.Write($"{node.Value} ");
            Console.WriteLine("\n");


            Console.WriteLine($"Number of Nodes in graph: {myGraph.Size()} \n");


            Console.WriteLine("Order after Breadth-First traversal: ");
            foreach (Node node in myGraph.BreadthFirst(firstNode))
                Console.Write($"{node.Value} ");
            Console.WriteLine("\n");


            Console.ReadLine();
        }
    }
}
