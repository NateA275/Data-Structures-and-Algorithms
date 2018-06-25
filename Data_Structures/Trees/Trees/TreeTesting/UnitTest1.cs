using System;
using Xunit;
using Trees.Classes;

namespace TreeTesting
{
    public class UnitTest1
    {
        [Fact]
        public void BinarySearchTreeCanAddLeftChild()
        {
            //Arrange
            BinarySearchTree bst = new BinarySearchTree();
            Node node5 = new Node(5);
            Node node4 = new Node(4);

            //Act
            bst.Add(node5, node4);

            //Assert
            Assert.Equal(node4, node5.LeftChild);
        }

        [Fact]
        public void BinarySearchTreeCanAddRightChild()
        {
            //Arrange
            BinarySearchTree bst = new BinarySearchTree();
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            //Act
            bst.Add(node5, node6);

            //Assert
            Assert.Equal(node6, node5.RightChild);
        }

        [Fact]
        public void BinarySearchTreeCanFindNodeThatExists()
        {
            //Arrange
            BinarySearchTree bst = new BinarySearchTree();
            Node rootNode = new Node(10);
            Node node15 = new Node(15);
            Node node5 = new Node(5);
            bst.Add(rootNode, node15);
            bst.Add(rootNode, node5);

            //Act
            Node found = bst.Search(rootNode, 5);

            //Assert
            Assert.Equal(node5, found);
        }

        [Fact]
        public void BinarySearchTreeReturnsNullForNodeThatDoesNotExist()
        {
            //Arrange
            BinarySearchTree bst = new BinarySearchTree();
            Node rootNode = new Node(10);
            Node node15 = new Node(15);
            Node node5 = new Node(5);
            bst.Add(rootNode, node15);
            bst.Add(rootNode, node5);

            //Act
            Node found = bst.Search(rootNode, 3);

            //Assert
            Assert.Null(found);
        }

        [Fact]
        public void BinaryTreeCanFindNodeThatExists()
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node(10);
            Node node15 = new Node(15);
            Node node5 = new Node(5);
            rootNode.RightChild = node15;
            rootNode.LeftChild = node5;

            //Act
            Node found = bt.Search(rootNode, 15);

            //Assert
            Assert.Equal(node15, found);
        }

        [Fact]
        public void BinaryTreeReturnsNullForNodeThatDoesNotExists()
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node(10);
            Node node15 = new Node(15);
            Node node5 = new Node(5);
            rootNode.RightChild = node15;
            rootNode.LeftChild = node5;

            //Act
            Node found = bt.Search(rootNode, 12);

            //Assert
            Assert.Null(found);
        }
    }
}
