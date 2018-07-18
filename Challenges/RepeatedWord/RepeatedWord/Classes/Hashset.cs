using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord.Classes
{
    public class Hashset
    {
        public string[] Set { get; set; } = new string[1024];


        public bool Add(string key)
        {
            int index = GetHash(key);

            if (Set[index] == null)
            {
                Set[index] = key;
                return true;
            }

            return false;
        }


        public int GetHash(string key)
        {
            int value = 0;

            foreach (char c in key) value += c;

            return value * 599 / 1024;
        }
    }
}
