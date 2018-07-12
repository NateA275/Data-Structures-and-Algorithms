using System;
using Animal_Shelter.Classes;

namespace Animal_Shelter
{
    class Program
    {
        static void Main(string[] args)
        {

            AnimalShelter myShelter = new AnimalShelter();

            myShelter.Enqueue(new Animal("Rover", "dog"));
            //myShelter.Enqueue(new Animal("Lily", "Dog"));
            //myShelter.Enqueue(new Animal("Josie", "cat"));

            Animal retrieved = myShelter.Dequeue("dog");

            Console.WriteLine(retrieved.Name);



            Console.ReadLine();
        }
    }
}
