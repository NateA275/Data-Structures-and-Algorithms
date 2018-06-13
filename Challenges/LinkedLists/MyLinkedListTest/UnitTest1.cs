using System;
using Xunit;
using LinkedLists.Classes;


namespace MyLinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToFront()
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
        public void CanFindNodeThatExists(int value, int expected)
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
        public void ReturnsNullForNodeThatDoesNotExist(int value)
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
        [InlineData(0, 4)]
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
        [InlineData(5)]
        public void KthElementReturnsNull(int value)
        {
            //Arrange
            MyLinkedList ll = new MyLinkedList(new Node(1));

            //Act
            Node found = ll.KthElement(value);

            //Assert
            Assert.Null(found);

        }
    }
}
