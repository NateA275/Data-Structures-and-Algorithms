# Left Join

This challenge is an exercise in utilizing Hashtables and Hashsets to hash and
store data in an efficient way.

## Challenge

Write a function that left joins two hashmaps into a single data structure.
LEFT JOIN means all the values in the first hashmap are returned, and if values 
exist in the “right” hashtable, they are appended to the result row. If no values exist 
in the right hashtable, then some flavor of NULL should be appended to the result row.


## Whiteboard

![Join_Left](../../assets/LeftJoin.jpg)

## Code
```C#
        /// <summary>
        /// JoinLeft - Combines two hashtables using a 'left join' method.
        /// </summary>
        /// <param name="h1"> Hashtable to be added to </param>
        /// <param name="h2"> Hashtable to be added </param>
        /// <returns> Appened-to hashtable </returns>
        public static Hashtable JoinLeft(Hashtable h1, Hashtable h2)
        {
            foreach (string key in h1.GetKeys())
                if (h2.Contains(key))
                    foreach (string value in h2.GetValues(key))
                        h1.Add(key, value);
                else
                    h1.Add(key, "NULL");

            return h1;
        }
```
