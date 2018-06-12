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
    }
}
