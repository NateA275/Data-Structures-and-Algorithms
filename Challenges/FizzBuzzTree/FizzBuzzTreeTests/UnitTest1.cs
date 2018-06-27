using FizzBuzzTree.Classes;
using System;
using Xunit;


namespace FizzBuzzTreeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3")]
        [InlineData("-6")]
        [InlineData("9")]
        [InlineData("33")]
        public void FizzBuzzTreeProducesFizzForMultiplesOfThree(string multiple)
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node(multiple);

            //Act
            bt.FizzBuzzTree(rootNode);

            //Assert
            Assert.Equal("Fizz", rootNode.Value);
        }


        [Theory]
        [InlineData("5")]
        [InlineData("10")]
        [InlineData("-25")]
        [InlineData("55")]
        public void FizzBuzzTreeProducesBuzzForMultiplesOfFive(string multiple)
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node(multiple);

            //Act
            bt.FizzBuzzTree(rootNode);

            //Assert
            Assert.Equal("Buzz", rootNode.Value);
        }


        [Theory]
        [InlineData("15")]
        [InlineData("-30")]
        [InlineData("45")]
        [InlineData("150")]
        public void FizzBuzzTreeProducesFizzBuzzForMultiplesOfFifteen(string multiple)
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node(multiple);

            //Act
            bt.FizzBuzzTree(rootNode);

            //Assert
            Assert.Equal("FizzBuzz", rootNode.Value);
        }


        [Theory]
        [InlineData("4")]
        [InlineData("8")]
        [InlineData("0")]
        [InlineData("31")]
        public void FizzBuzzDoesNotChangeNonMultiples(string value)
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node(value);

            //Act
            bt.FizzBuzzTree(rootNode);

            //Assert
            Assert.Equal(value, rootNode.Value);
        }


        [Theory]
        [InlineData("String")]
        [InlineData(null)]
        [InlineData("3.0")]
        [InlineData("Node")]
        public void FizzBuzzDoesNotChangeNonIntegers(string value)
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node(value);

            //Act
            bt.FizzBuzzTree(rootNode);

            //Assert
            Assert.Equal(value, rootNode.Value);
        }


        [Theory]
        [InlineData("3", "Fizz")]
        [InlineData("20", "Buzz")]
        [InlineData("21", "Fizz")]
        [InlineData("45", "FizzBuzz")]
        public void FizzBuzzTraversesLeftChild(string value, string expected)
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node("15");
            Node leftChild = new Node(value);
            rootNode.LeftChild = leftChild;

            //Act
            bt.FizzBuzzTree(rootNode);

            //Assert
            Assert.Equal(expected, leftChild.Value);
        }


        [Theory]
        [InlineData("3", "Fizz")]
        [InlineData("20", "Buzz")]
        [InlineData("21", "Fizz")]
        [InlineData("45", "FizzBuzz")]
        public void FizzBuzzTraversesRightChild(string value, string expected)
        {
            //Arrange
            BinaryTree bt = new BinaryTree();
            Node rootNode = new Node("15");
            Node rightChild = new Node(value);
            rootNode.RightChild = rightChild;

            //Act
            bt.FizzBuzzTree(rootNode);

            //Assert
            Assert.Equal(expected, rightChild.Value);
        }
    }
}
