using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        public Stack<Node>[] Table { get; set; } = new Stack<Node>[1024];


        // void Add(key, value)
        public void Add(string key, int value)
        {
            if (Contains(key))
                throw new Exception($"Key '{key}' already exists in table.");

            int index = GetHash(key);

            if (Table[index] == null)
                Table[index] = new Stack<Node>();

            Table[index].Push(new Node(key, value));
        }


        // int Find(string key)
        public int Find(string key)
        {
            int index = GetHash(key);

            if (Table[index] != null)
                foreach (Node node in Table[index])
                    if (node.Key == key)
                        return node.Value;

            throw new Exception($"Key '{key}' does not exist in table.");
        }


        // bool Contains(string key)
        public bool Contains(string key)
        {
            int index = GetHash(key);

            if (Table[index] != null)
                foreach (Node node in Table[index])
                    if (node.Key == key)
                        return true;

            return false;
        }


        // int GetHash(string key)
        public int GetHash(string key)
        {
            int value = 0;

            foreach (char c in key) value += c;

            return value * 599 / 1024;
        }
    }
}
