using System;
using Xunit;
using Tree_Intersection.Classes;
using Tree_Intersection;

namespace FindIntersectionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100)]
        [InlineData(78)]
        [InlineData(0)]
        public void FindIntersectionFindsIntersection(int value)
        {
            //Arrange
            Node root1 = new Node(value);
            Node root2 = new Node(value);

            //Act
            int[] result = Program.FindIntersection(root1, root2);

            //Assert
            Assert.Equal(value, result[0]);
        }

        [Fact]
        public void FindIntersectionReturnsEmptyArrayIfNoMatches()
        {
            //Arrange
            Node root1 = new Node(10);
            Node root2 = new Node(5);

            //Act
            int[] result = Program.FindIntersection(root1, root2);

            //Assert
            Assert.Empty(result);
        }


        [Theory]
        [InlineData(1)]
        [InlineData(1000)]
        [InlineData(0)]
        public void FindIntersectionCanFindIntersectionOnUnEvenTrees(int value)
        {
            //Arrange
            Node root1 = new Node(value);
            Node root2 = new Node(10);
            root2.RightChild = new Node(value);

            //Act
            int[] result = Program.FindIntersection(root1, root2);

            //Assert
            Assert.Equal(value, result[0]);
        }
    }
}
