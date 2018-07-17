using System;
using Xunit;
using Hashtables.Classes;
using System.Collections.Generic;

namespace TestHashtable
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("cat", 182)]
        [InlineData("a", 56)]
        [InlineData("BLUE", 173)]
        [InlineData("blue", 248)]
        public void GetHashCreatesUniqueHashValue(string word, int value)
        {
            //Arrange
            Hashtable table = new Hashtable();

            //Act
            int result = table.GetHash(word);

            //Assert
            Assert.Equal(value, result);
        }


        [Theory]
        [InlineData("cat", 182)]
        [InlineData("a", 56)]
        [InlineData("BLUE", 173)]
        [InlineData("blue", 248)]
        public void ContainsCanReturnTrueIfElementExists(string word, int index)
        {
            //Arrange
            Hashtable table = new Hashtable();
            table.Table[index] = new Stack<Node>();
            table.Table[index].Push(new Node(word, 15));

            //Act
            bool result = table.Contains(word);

            //Assert
            Assert.True(result);
        }


        [Theory]
        [InlineData("cat")]
        [InlineData("a")]
        [InlineData("BLUE")]
        [InlineData("blue")]
        public void AddCanAddNodeToHashtable(string word)
        {
            //Arrange
            Hashtable table = new Hashtable();

            //Act
            table.Add(word, 15);

            //Assert
            Assert.True(table.Contains(word));
        }


        [Fact]
        public void HashtableCanAddWithCollisions()
        {
            //Arrange
            Hashtable table = new Hashtable();

            //Act
            table.Add("cat", 50); //index of 182
            table.Add("doe", 50); //index of 182

            //Assert
            Assert.True(table.Contains("doe"));
        }


        [Fact]
        public void HashtableThrowsExceptionForEqualKeys()
        {
            //Arrange
            Hashtable table = new Hashtable();
            table.Add("cat", 10);

            //Act
            Exception ex = Assert.Throws<Exception>(() => table.Add("cat", 15));

            //Assert
            Assert.Equal("Key 'cat' already exists in table.", ex.Message);
        }

    }
}
