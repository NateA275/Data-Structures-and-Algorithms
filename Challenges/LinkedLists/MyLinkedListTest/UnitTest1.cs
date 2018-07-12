using System;
using Xunit;
using LinkedLists.Classes;


namespace MyLinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddCanAddNodeToFront()
        {
            //Arrange
            MyLinkedList ll = new MyLinkedList(new Node(4));
            Node n8 = new Node(8);
            Node n7 = new Node(7);
            Node n16 = new Node(16);

            //Act
            ll.Add(n8);
            ll.Add(n7);
            ll.Add(n16);

            //Assert
            Assert.Equal(ll.Head.Value, n16.Value);

        }


        [Theory]
        [InlineData(8, 8)]
        [InlineData(23, 23)]
        [InlineData(16, 16)]
        public void FindCanFindNodeThatExists(int value, int expected)
        {
            //Arrange
            MyLinkedList ll = new MyLinkedList(new Node(4));
            Node n8 = new Node(8);
            Node n23 = new Node(23);
            Node n16 = new Node(16);

            //Act
            ll.Add(n8);
            ll.Add(n23);
            ll.Add(n16);
            Node found = ll.Find(value);

            //Assert
            Assert.Equal(expected, found.Value);
        }


        [Theory]
        [InlineData(42)]
        [InlineData(100)]
        [InlineData(-10)]
        public void FindReturnsNullForNodeThatDoesNotExist(int value)
        {
            //Arrange
            MyLinkedList ll = new MyLinkedList(new Node(4));
            Node n8 = new Node(8);
            Node n23 = new Node(23);
            Node n16 = new Node(16);

            //Act
            ll.Add(n8);
            ll.Add(n23);
            ll.Add(n16);
            Node found = ll.Find(value);

            //Assert
            Assert.Null(found);
        }


        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 2)]
        [InlineData(3, 1)]
        public void KthElementReturnsNode(int value, int expected)
        {
            //Arrange
            MyLinkedList ll = new MyLinkedList(new Node(1));
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);

            //Act
            ll.AddLast(n2);
            ll.AddLast(n3);
            ll.AddLast(n4);
            Node found = ll.KthElement(value);

            //Assert
            Assert.Equal(expected, found.Value);
        }


        [Theory]
        [InlineData(2)]
        public void KthElementCanGetLastElement(int value)
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList(new Node(1));
            list1.AddLast(new Node(value));

            //Act
            Node foundNode = list1.KthElement(0);

            //Assert
            Assert.Equal(foundNode.Value, value);
        }


        [Theory]
        [InlineData(5)]
        [InlineData(2)]
        [InlineData(1)]
        public void KthElementThrowsException(int value)
        {
            //Arrange
            MyLinkedList ll = new MyLinkedList(new Node(1));

            //Act
            Exception ex = Assert.Throws<NullReferenceException>(() => ll.KthElement(value));

            //Assert
            Assert.Equal("Object reference not set to an instance of an object.", ex.Message);
        }


        [Fact]
        public void MergeReturnsNode()
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList(new Node(1));
            MyLinkedList list2 = new MyLinkedList(new Node(5));

            //Act
            Node found = list1.Merge(list1, list2);

            //Assert
            Assert.IsType<Node>(found);
        }


        [Theory]
        [InlineData(0, 4)]
        [InlineData(1, 15)]
        [InlineData(2, 3)]
        [InlineData(3, 10)]
        public void MergePutsNodesInCorrectOrder(int k, int value)
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList(new Node(1));
            MyLinkedList list2 = new MyLinkedList(new Node(5));

            //Act
            list1.AddLast(new Node(2));
            list1.AddLast(new Node(3));
            list1.AddLast(new Node(4));
            list2.AddLast(new Node(10));
            list2.AddLast(new Node(15));
            list1.Merge(list1, list2);
            Node found = list1.KthElement(k);

            //Assert
            Assert.Equal(value, found.Value);
        }


        [Theory]
        [InlineData(0, 20)]
        [InlineData(1, 15)]
        [InlineData(2, 10)]
        [InlineData(3, 2)]
        [InlineData(4, 5)]
        [InlineData(5, 1)]
        public void MergeWorksWhenSecondListIsLonger(int k, int value)
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList(new Node(1));
            MyLinkedList list2 = new MyLinkedList(new Node(5));

            //Act
            list1.AddLast(new Node(2));
            list2.AddLast(new Node(10));
            list2.AddLast(new Node(15));
            list2.AddLast(new Node(20));
            list1.Merge(list1, list2);
            Node found = list1.KthElement(k);

            //Assert
            Assert.Equal(value, found.Value);
        }


        [Theory]
        [InlineData(0, 5)]
        [InlineData(2, 3)]
        [InlineData(3, 10)]
        [InlineData(4, 2)]
        [InlineData(6, 1)]
        public void MergeWorksWhenFirstListIsLonger(int k, int value)
        {
            //Arrange
            MyLinkedList list1 = new MyLinkedList(new Node(1));
            MyLinkedList list2 = new MyLinkedList(new Node(5));

            //Act
            list1.AddLast(new Node(2));
            list1.AddLast(new Node(3));
            list1.AddLast(new Node(4));
            list1.AddLast(new Node(5));
            list2.AddLast(new Node(10));
            list1.Merge(list1, list2);
            Node found = list1.KthElement(k);

            //Assert
            Assert.Equal(value, found.Value);
        }


        [Fact]
        public void AddAfterCanAddAfter()
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            MyLinkedList list1 = new MyLinkedList(firstNode);
            list1.AddLast(thirdNode);

            //Act
            list1.AddAfter(secondNode, firstNode);
            Node found = list1.KthElement(1);

            //Assert
            Assert.Equal(secondNode, found);
        }


        [Fact]
        public void AddAfterCanAddLast()
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            MyLinkedList list1 = new MyLinkedList(firstNode);

            //Act
            list1.AddAfter(secondNode, firstNode);
            Node found = list1.KthElement(0);

            //Assert
            Assert.Equal(secondNode, found);
        }


        [Fact]
        public void AddAfterDoesNothingIfExistingNodeDoesNotExist()
        {
            //Arrange
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            MyLinkedList list1 = new MyLinkedList(firstNode);

            //Act
            list1.AddAfter(thirdNode, secondNode);
            Node found = list1.KthElement(0);

            //Assert
            Assert.NotEqual(found, thirdNode);
            Assert.Equal(found, firstNode);
        }


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
