using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter.Classes
{
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
}
