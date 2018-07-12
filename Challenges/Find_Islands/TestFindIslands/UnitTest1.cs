using Xunit;
using Find_Islands;


namespace TestFindIslands
{
    public class UnitTest1
    {
        [Fact]
        public void FindIslandsReturnsZeroIfMatrixContainsNoElements()
        {
            //Arrange
            int[,] matrix = new int[,]
                { };

            //Act
            int response = Program.FindIslands(matrix);

            //Assert
            Assert.Equal(0, response);
        }

        [Fact]
        public void FindIslandsReturnsOneIfMatrixOnlyContainsOneIsland()
        {
            //Arrange
            int[,] matrix = new int[,]
                {
                    { 0, 0, 1},
                    { 1, 0, 1},
                    { 1, 0, 0},
                };

            //Act
            int response = Program.FindIslands(matrix);

            //Assert
            Assert.Equal(1, response);
        }

        [Fact]
        public void FindIslandsCanFindMultipleIslands()
        {
            //Arrange
            int[,] matrix = new int[,]
                {
                    {0, 1, 0, 0, 0},
                    {1, 0, 0, 0, 0},
                    {0, 0, 0, 1, 0},
                    {0, 0, 1, 0, 0},
                    {0, 0, 0, 0, 0}
                };

            //Act
            int response = Program.FindIslands(matrix);

            //Assert
            Assert.Equal(3, response);
        }

        [Fact]
        public void FindIslandsCanSolveStarShapedGraph()
        {
            //Arrange
            int[,] matrix = new int[,]
                {
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 1, 1, 1, 1, 1, 0},
                };

            //Act
            int response = Program.FindIslands(matrix);

            //Assert
            Assert.Equal(1, response);
        }

        [Fact]
        public void FindIslandCanSolveForNodesThatConnectToThemsleves()
        {
            //Arrange
            int[,] matrix = new int[,]
                {
                    { 1, 0, 0},
                    { 0, 1, 0},
                    { 0, 0, 1},
                };

            //Act
            int response = Program.FindIslands(matrix);

            //Assert
            Assert.Equal(3, response);
        }
    }
}
