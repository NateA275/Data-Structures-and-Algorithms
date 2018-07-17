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

                Console.WriteLine(table.Find("cat"));
                Console.WriteLine(table.Find("doe"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
