using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoin.Classes
{
    public class Hashtable
    {
        Bucket[] Table = new Bucket[1024];

        // Add
        public void Add(string key, string value)
        {
            int index = GetHash(key);
            Bucket bucket = new Bucket(key, value);

            if (Table[index] != null)
                bucket.Next = Table[index];

            Table[index] = bucket;
        }


        // Contains
        public bool Contains(string key)
        {
            int index = GetHash(key);

            if (Table[index] != null)
            {
                Bucket row = Table[index];

                while (row.Next != null)
                {
                    if (row.Key == key)
                        return true;

                    row = row.Next;
                }

                if (row.Key == key)
                    return true;
            }

            return false;
        }


        // GetHash
        public int GetHash(string key)
        {
            int value = 0;

            foreach (char c in key) value += c;

            return value * 599 / 1024;
        }


        // Foreach yield unique keys
        public IEnumerable<string> GetKeys()
        {
            foreach (Bucket head in Table)
                if (head != null)
                {   
                    Bucket runner = head;

                    while (runner.Next != null)
                    {
                        yield return runner.Key;
                        runner = runner.Next;
                    }

                    yield return runner.Key;
                }
        }


        // Foreach yield values
        public IEnumerable<string> GetValues(string key)
        {
            int index = GetHash(key);

            if (Table[index] != null)
            {
                Bucket row = Table[index];

                while (row.Next != null)
                {
                    if (row.Key == key)
                        yield return row.Value;

                    row = row.Next;
                }

                if (row.Key == key)
                    yield return row.Value;
            }
        }


        // Print
        public void PrintTable()
        {
            string keyRef = "";

            foreach (string key in GetKeys())
                if (keyRef != key)
                {
                    IEnumerable<string> values = GetValues(key);
                    Console.WriteLine($"{key}: {string.Join(", ", values)}");
                    keyRef = key;
                }
        }
    }
}
