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

            // string[] words = userSentence.Split(" ");
            // int count = 0;

            // for (int i = 0; i < words.Length; i++)
            // {
            //     if (words[i].Equals(userWord))
            //     {
            //         count+= 1;
            //     }
            // }
            // Console.WriteLine(count);
        }
    }
}