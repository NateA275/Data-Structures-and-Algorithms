using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoin.Classes
{
    public class Bucket
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Bucket Next { get; set; }

        public Bucket(string key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
