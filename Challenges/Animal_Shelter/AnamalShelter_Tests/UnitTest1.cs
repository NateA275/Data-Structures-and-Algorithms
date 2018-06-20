using System;
using Xunit;
using Animal_Shelter.Classes;

namespace AnamalShelter_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueAddsNewAnimalToShelter()
        {
            //Arrange
            AnimalShelter myShelter = new AnimalShelter();
            Animal firstAnimal = new Animal("Lily", "dog");

            //Act   
            myShelter.Enqueue(firstAnimal);

            //Assert
            Assert.Equal(firstAnimal, myShelter.Head);
        }

        [Fact]
        public void EnqueueAddsNewAnimalToTail()
        {
            //Arrange
            AnimalShelter myShelter = new AnimalShelter();
            Animal firstAnimal = new Animal("Lily", "dog");
            Animal secondAnimal = new Animal("Josie", "cat");

            //Act
            myShelter.Enqueue(firstAnimal);
            myShelter.Enqueue(secondAnimal);

            //Assert
            Assert.Equal(secondAnimal, myShelter.Tail);
        }

        [Theory]
        [InlineData("dog")]
        [InlineData("cat")]
        public void EnqueueCanAddCatsAndDogs(string type)
        {
            //Arrange
            AnimalShelter myShelter = new AnimalShelter();
            Animal firstAnimal = new Animal("Lily", type);

            //Act
            myShelter.Enqueue(firstAnimal);

            //Assert
            Assert.Equal(type, myShelter.Head.Type);
        }


        [Fact]
        public void DequeueCanReturnFirstCat()
        {
            //Arrange
            AnimalShelter myShelter = new AnimalShelter();
            Animal firstAnimal = new Animal("Lily", "dog");
            Animal secondAnimal = new Animal("Josie", "cat");
            myShelter.Enqueue(firstAnimal);
            myShelter.Enqueue(secondAnimal);

            //Act
            Animal selected = myShelter.Dequeue("cat");

            //Assert
            Assert.Equal(secondAnimal, selected);
        }

        [Fact]
        public void DequeueCanReturnFirstDog()
        {
            //Arrange
            AnimalShelter myShelter = new AnimalShelter();
            Animal firstAnimal = new Animal("Josie", "cat");
            Animal secondAnimal = new Animal("Lily", "dog");
            myShelter.Enqueue(firstAnimal);
            myShelter.Enqueue(secondAnimal);

            //Act
            Animal selected = myShelter.Dequeue("dog");

            //Assert
            Assert.Equal(secondAnimal, selected);
        }

        [Fact]
        public void IfPreferanceDoesntExistDequeuReturnsFirstAnimal()
        {
            //Arrange
            AnimalShelter myShelter = new AnimalShelter();
            Animal firstAnimal = new Animal("Oreo", "cat");
            Animal secondAnimal = new Animal("Josie", "cat");
            myShelter.Enqueue(firstAnimal);
            myShelter.Enqueue(secondAnimal);

            //Act
            Animal selected = myShelter.Dequeue("rabbit");

            //Assert
            Assert.Equal(firstAnimal, selected);
        }
    }
}
