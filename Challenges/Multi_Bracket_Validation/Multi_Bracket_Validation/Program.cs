using System;
using Multi_Bracket_Validation.Classes;

namespace Multi_Bracket_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiBracketValidation("String[i].ToArray()"));
            Console.ReadLine();
        }

        /// <summary>
        /// MultiBracketValidation - Verifies if input string contains validly formatted bracketing.
        /// </summary>
        /// <param name="input"> string - Input to be validated for bracketing </param>
        /// <returns>bool - True if valid, false if not. </returns>
        public static bool MultiBracketValidation(string input)
        {
            string validChars = "(){}[]";

            Stack myStack = new Stack();

            foreach (char c in input)
            {
                if (validChars.Contains(c))
                {
                    if (myStack.Top == null)
                    {
                        myStack.Push(new Node(c));
                    }
                    else if (CompareBrackets(myStack.Top.Value, c))
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        myStack.Push(new Node(c));
                    }
                }
            }
            return (myStack.Top == null) ? true : false;
        }


        /// <summary>
        /// CompareBracts - Checks to see if two characters are equivilent opening and closing brackets
        /// </summary>
        /// <param name="first">char - Opening Bracket</param>
        /// <param name="second">char - Closing Bracket</param>
        /// <returns>bool - True if matching, False if not. </returns>
        public static bool CompareBrackets(char first, char second)
        {
            char equiv;

            switch (first)
            {
                case '{':
                    equiv = '}';
                    break;
                case '(':
                    equiv = ')';
                    break;
                case '[':
                    equiv = ']';
                    break;
                default:
                    return false;
            }

            return (second == equiv) ? true : false;
        }
    }
}
