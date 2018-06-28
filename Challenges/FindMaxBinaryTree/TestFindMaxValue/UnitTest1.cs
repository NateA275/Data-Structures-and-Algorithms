using FindMaxBinaryTree.Classes;
using System;
using Xunit;

namespace TestFindMaxValue
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxValueReturnsLargestInteger()
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node root = new Node(1);
            bt.Add(root, new Node(10));

            //Act
            int response = bt.FindMaximumValue(root);

            //Assert
            Assert.Equal(10, response);
        }

        [Fact]
        public void FindMaxValueFindsLeftBranches()
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node root = new Node(1);
            Node node1 = new Node(1);
            Node node2 = new Node(8);
            root.LeftChild = node1;
            node1.LeftChild = node2;

            //Act
            int response = bt.FindMaximumValue(root);

            //Assert
            Assert.Equal(8, response);
        }

        [Fact]
        public void FindMaxValueFindsRightbranches()
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node root = new Node(1);
            Node node1 = new Node(1);
            Node node2 = new Node(8);
            root.RightChild = node1;
            node1.RightChild = node2;

            //Act
            int response = bt.FindMaximumValue(root);

            //Assert
            Assert.Equal(8, response);
        }

        [Fact]
        public void FindMaxValueHandlesNegativeNumbers()
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node root = new Node(-21);
            bt.Add(root, new Node(-5));
            bt.Add(root, new Node(-3));
            bt.Add(root, new Node(-15));
            bt.Add(root, new Node(-2));
            bt.Add(root, new Node(-7));

            //Act
            int response = bt.FindMaximumValue(root);

            //Assert
            Assert.Equal(-2, response);
        }

    }
}
