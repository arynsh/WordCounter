using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counts;
using System;
using System.Collections.Generic;

namespace Counts.Tests 
{
    [TestClass]
    public class CountsTest
    {

        [TestMethod]
        public void Main_ReturnsLower_string()
        {
            string userInputWord = "I";
            string result = userInputWord.ToLower();
            Assert.AreEqual("i", result);
        }

        [TestMethod]
        public void Main_ReturnsLowerSent_string()
        {
            string userInputSentence = "I SURE DO LOVE PANCAKES";
            string result = userInputSentence.ToLower();
            Assert.AreEqual("i sure do love pancakes", result);
        }

         [TestMethod]
        public void Counter_ReturnsNothingIfWordIsPart_int()
        {
            string userInputWord = "I";
            string userInputSentence = "I'm hungry";
            RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
            int result = userInput.Counter();
            Assert.AreEqual(0, result);
        }       

        [TestMethod]
        public void ToArray_ReturnsJoinedArr_string()
        {
            string userInputSentence = "raining today";
            string userInputWord = "raining";
            RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
            string result = string.Join(", ",(userInput.ToArray()));
            Assert.AreEqual("raining, today", result);
        }

        [TestMethod]
        public void Counter_ReturnsNumOfTimesWordAppears_int()
        {
            string userInputWord = "green";
            string userInputSentence = "Look at the green birds hiding in greenery on that very green tree";
            RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
            int result = userInput.Counter();
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Counter_ReturnsZero_int()
        {
            string userInputWord = "Mango";
            string userInputSentence = "What kinds of fruits do you like to eat";
            RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
            int result = userInput.Counter();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Counter_ReturnsNumOfTimesWord_int()
        {
            string userInputWord = "dog";
            string userInputSentence = "the doghouse is in the backyard";
            RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
            int result = userInput.Counter();
            Assert.AreEqual(0, result);
        }
        

    }
}