using System;
using Xunit;
using Queue.Classes;

namespace Test_Queue
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10)]
        [InlineData(1000)]
        [InlineData(-20)]
        public void EnqueueAddsNodeToTail(int value)
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(value);
            MyQueue queue1 = new MyQueue(firstNode);

            //Act
            queue1.Enqueue(secondNode);

            //Assert
            Assert.Equal(secondNode.Value, queue1.Tail.Value);
        }

        [Fact]
        public void DequeueReturnsNode()
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            MyQueue queue1 = new MyQueue(firstNode);
            queue1.Enqueue(secondNode);

            //Act
            Node returned = queue1.Dequeue();

            //Assert
            Assert.Equal(firstNode, returned);
        }


        [Fact]
        public void DequeueRemovesNodeFromHead()
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            MyQueue queue1 = new MyQueue(firstNode);
            queue1.Enqueue(secondNode);

            //Act
            Node returned = queue1.Dequeue();

            //Assert
            Assert.Equal(secondNode, queue1.Head);
        }
    }
}