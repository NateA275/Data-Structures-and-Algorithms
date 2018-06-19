using System;
using Xunit;
using Stacks.Classes;

namespace Stack_Test
{
    public class UnitTest1
    {
        [Fact]
        public void PushAddsNodeToTopOfStack()
        {
            //Arrange
            MyStack newStack = new MyStack(new Node(1));
            Node secondNode = new Node(2);

            //Act
            newStack.Push(secondNode);

            //Assert
            Assert.Equal(newStack.Top, secondNode);
        }

        [Fact]
        public void PopRemovesNodeFromTop()
        {
            //Arrange
            MyStack newStack = new MyStack(new Node(1));
            newStack.Push(new Node(2));
            newStack.Push(new Node(3));

            //Act
            Node returned = newStack.Pop();

            //Assert
            Assert.Equal(3, returned.Value);
        }

        [Fact]
        public void PeekReturnsValueOfTopNode()
        {
            //Arrange
            MyStack newStack = new MyStack(new Node(1));
            newStack.Push(new Node(2));
            newStack.Push(new Node(3));

            //Act
            int value = newStack.Peek();

            //Assert
            Assert.Equal(3, value);
        }
    }
}