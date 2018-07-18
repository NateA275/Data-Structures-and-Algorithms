using System;
using RepeatedWord.Classes;


namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "It was the best of times, it was the worst of times.";

            Console.WriteLine(RepeatedWord(testString));

            Console.ReadLine();
        }


        public static string RepeatedWord(string input)
        {
            string[] allwords = input.ToLower().Split(" ");
            Hashset wordSet = new Hashset();

            foreach (string word in allwords)
            {
                if (!wordSet.Add(word))
                    return word;
            }

            return "no duplicates";
        }
    }
}

