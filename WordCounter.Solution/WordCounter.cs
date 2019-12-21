using System;
using System.Collections.Generic;

namespace Counts
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word:");
            string userWord = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter a sentence:");
            string userSentence = Console.ReadLine().ToLower();

            RepeatCounter userInput = new RepeatCounter(userWord, userSentence);

            Console.WriteLine(userInput.Counter());

            // if (userInput.CheckParse(userWord).Equals(false))
            // {
            //     Console.WriteLine(userInput.Counter());
            // }
            // else
            // { 
            //     Console.WriteLine("Invalid input");
            // }
        }
    }
}