using LeftJoin.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            // First Hashtable
            Hashtable ht = new Hashtable();
            ht.Add("fond", "enamored");
            ht.Add("wrath","anger");
            ht.Add("diligent", "employed");
            ht.Add("outfit", "garb");
            ht.Add("guide", "usher");


            // Second Hashtable
            Hashtable ht2 = new Hashtable();
            ht2.Add("fond", "averse");
            ht2.Add("wrath", "delight");
            ht2.Add("diligent", "idle");
            ht2.Add("guide", "follow");


            // Display
            Console.WriteLine("--Hashtable 1--");
            ht.PrintTable();

            Console.WriteLine("\n--Hashtable 2--");
            ht2.PrintTable();

            Console.WriteLine("\n--After Left Join--");
            JoinLeft(ht, ht2).PrintTable();

            Console.ReadLine();
        }


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
    }
}
