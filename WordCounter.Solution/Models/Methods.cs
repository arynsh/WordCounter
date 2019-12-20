using System;
using System.Collections.Generic;

namespace Counts
{
    public class RepeatCounter
    {
        public string UserWord { get; set; }
        public string UserSentence { get; set; }

        public RepeatCounter(string userWord, string userSentence)
        {
            UserWord = userWord;
            UserSentence = userSentence;
        }

        public int Counter()
        {
            string[] words = UserSentence.Split(" ");
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(UserWord))
                {
                    count+= 1;
                }
            }
            return count;
        }

        public string[] ToArray()
        {
            string[] arrSentence = UserSentence.Split(" ");
            return arrSentence;
        }
    }
}