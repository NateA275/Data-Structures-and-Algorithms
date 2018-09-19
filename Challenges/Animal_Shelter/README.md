# Animal Shelter

This challenge is a exercise in manipulating linear data structures.
A "FIFO" (first-in-first-out) data structure is used to Emulate an Animal Adoption Shelter,
where the first Animals placed into the shelter are prioritized for retrieval.

## Challenge

Implement the following methods for the AnimalShelter class:

Enqueue(Animal) which inserts an Animal object into the Shelter using a first-in, first-out approach.

Dequeue(Preferance) which extracts an Animal with the preferred type from the Shelter using a first-in, first-out approach.
	If a matching preferance does not exist, the current first-in Animal is returned.


## Whiteboard

![animal_shelter](../../assets/animal_shelter.jpg)

## Code
```C#
public class AnimalShelter
    {
        public Animal Head { get; set; }
        public Animal Tail { get; set; }

        public AnimalShelter()
        {
            Head = null;
            Tail = null;
        }


        /// <summary>
        /// Enqueue - Adds an Animal object to the Shelter
        /// </summary>
        /// <param name="newAnimal"> Animal - animal to be added to the Shelter </param>
        public void Enqueue(Animal newAnimal)
        {
            if (Tail != null)
                Tail.Next = newAnimal;

            Tail = newAnimal;

            if (Head == null)
                Head = newAnimal;
        }


        /// <summary>
        /// Dequeue - Retrieves an Animal with requested type. If one does not exist in the shelter,
        /// the first animal into the shelter is returned.
        /// </summary>
        /// <param name="preferance"> string - User's animal preferance type </param>
        /// <returns> Animal - Animal object </returns>
        public Animal Dequeue(string preferance)
        {
            Animal runner = Head;
            Animal selected;

            while (runner.Next != null)
            {
                if (runner.Next.Type.ToUpper() == preferance.ToUpper())
                {
                    selected = runner.Next;
                    runner.Next = selected.Next;
                    return selected;
                }
                runner = runner.Next;
            }

            selected = Head;
            Head = selected.Next;
            return selected;
        }
    }
```
