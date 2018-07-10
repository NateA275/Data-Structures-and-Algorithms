using System;
using Xunit;
using Graphs;
using System.Collections.Generic;

namespace GraphTesting
{
    public class UnitTest1
    {
        [Fact]
        public void SizeReturnsCorrectNumberOfNodes()
        {
            //Arrange
            Graph myGraph = new Graph(new Node(1));

            //Act
            int number = myGraph.Size();

            //Assert
            Assert.Equal(1, number);
        }


        [Fact]
        public void GetNeighborsReturnsListOfNodes()
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            Graph myGraph = new Graph(firstNode);
            firstNode.Neighbors.Add(secondNode);
            firstNode.Neighbors.Add(thirdNode);

            //Act
            List<Node> testList = new List<Node>();
            testList.Add(secondNode);
            testList.Add(thirdNode);
            List<Node> results = myGraph.GetNeighbors(firstNode);

            //Assert
            Assert.Equal(testList, results);
        }

        [Fact]
        public void AddEdgeCanAddBiderectionalEdge()
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Graph myGraph = new Graph(firstNode);

            //Act
            myGraph.AddEdge(firstNode, secondNode);

            //Assert
            Assert.Contains(secondNode, firstNode.Neighbors);
        }
    }
}
