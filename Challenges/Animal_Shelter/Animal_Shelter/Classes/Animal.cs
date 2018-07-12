using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Animal Next { get; set; }

        public Animal(string name, string type)
        {
            Name = name;
            Type = type;
            Next = null;
        }

    }
}
