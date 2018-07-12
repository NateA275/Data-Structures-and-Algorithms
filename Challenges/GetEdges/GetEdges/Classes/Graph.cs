using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        public List<Node> AllCities { get; set; } = new List<Node>();


        public Graph(Node node)
        {
            AllCities.Add(node);    
        }


        //Adds new Vertice to graph with weighted edge
        public void AddEdge(Node firstNode, Node secondNode, int weight)
        {
            if (!AllCities.Contains(firstNode))
                AllCities.Add(firstNode);
                
            if (!AllCities.Contains(secondNode))
                AllCities.Add(secondNode);

            firstNode.Connections.Add(secondNode, weight);
            secondNode.Connections.Add(firstNode, weight);
        }


        //find if string exisits in all cities



        public void GetEdges(string[] destinations)
        {

        }
    }
}