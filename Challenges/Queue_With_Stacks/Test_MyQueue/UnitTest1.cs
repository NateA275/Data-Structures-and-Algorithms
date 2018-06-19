using System;
using Xunit;
using Queue_With_Stacks.Classes;

namespace Test_MyQueue
{
    public class UnitTest1
    {

        [Fact]
        public void PeekReturnsValueOfFirstNodeInQueue()
        {
            //Arrange
            Queue myQueue = new Queue();
            Node firstNode = new Node(1);
            myQueue.Enqueue(firstNode);

            //Act
            int returnedValue = myQueue.Peek();

            //Assert
            Assert.Equal(firstNode.Value, returnedValue);
        }


        [Theory]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(15)]
        public void EnqueueAddsNodeToQueue(int value)
        {
            //Arrange
            Queue myQueue = new Queue();
            Node firstNode = new Node(value);

            //Act
            myQueue.Enqueue(firstNode);
            int returned = myQueue.Peek();

            //Assert
            Assert.Equal(returned, value);
        }


        [Theory]
        [InlineData(17)]
        [InlineData(12)]
        [InlineData(-15)]
        public void EnqueueAddsNodeToEndOfQueue(int value)
        {
            //Arrange
            Queue myQueue = new Queue();
            Node firstNode = new Node(value);
            Node secondNode = new Node(2);

            //Act
            myQueue.Enqueue(firstNode);
            myQueue.Enqueue(secondNode);

            //Assert
            Assert.Equal(firstNode.Value, myQueue.Peek());

        }


        [Fact]
        public void DequeueReturnsNode()
        {
            //Arrange
            Queue myQueue = new Queue();
            Node firstNode = new Node(5);

            //Act
            myQueue.Enqueue(firstNode);
            Node returned = myQueue.Dequeue();

            //Assert
            Assert.Equal(returned, firstNode);
        }


        [Fact]
        public void DequeueRemovesNodeFromFirstPositionInQueue()
        {
            //Arrange
            Queue myQueue = new Queue();
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);

            //Act
            myQueue.Enqueue(firstNode);
            myQueue.Enqueue(secondNode);
            myQueue.Dequeue();
            int returnedValue = myQueue.Peek();

            //Assert
            Assert.NotEqual(firstNode.Value, returnedValue);
        }
    }
}
