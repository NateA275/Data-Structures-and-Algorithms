using System;
using Hashtables.Classes;

namespace Hashtables
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            try
            {
                table.Add("cat", 50);
                table.Add("doe", 25);
                table.Add("Cat", 17);


                Console.WriteLine($"'cat' exists in hashtable: {table.Contains("cat")}");
                Console.WriteLine("Expected value of 'cat': 50");
                Console.WriteLine($"Found: {table.Find("cat")}");

                Console.WriteLine($"'doe' exists in hashtable: {table.Contains("doe")}");
                Console.WriteLine("Expected value of 'doe': 25");
                Console.WriteLine($"Found: {table.Find("doe")}");

                Console.WriteLine($"'Cat' exists in hashtable: {table.Contains("Cat")}");
                Console.WriteLine("Expected value of 'Cat': 17");
                Console.WriteLine($"Found: {table.Find("Cat")}");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
