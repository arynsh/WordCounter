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
            string userInputSentence = "I am";
            string result = userInputSentence.ToLower();
            Assert.AreEqual("i am", result);
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
        public void Counter_ReturnsNumOfTimesWordAppears_int()
        {
            string userInputWord = "green";
            string userInputSentence = "Look at the green birds hiding in greenery on that very green tree";
            RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
            int result = userInput.Counter();
            Assert.AreEqual(2, result);
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

        // [TestMethod]
        // public void CheckParse_ReturnsBool_bool()
        // {
        //     string userInputWord = "1";
        //     string userInputSentence = "1234567";
        //     RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
        //     bool result = userInput.CheckParse(userInputWord);
        //     Assert.AreEqual(false, result);
        // }

        //  [TestMethod]
        // public void ToArray_ReturnsJoinedArr_string()
        // {
        //     string userInputSentence = "raining today";
        //     string userInputWord = "raining";
        //     RepeatCounter userInput = new RepeatCounter(userInputWord, userInputSentence);
        //     string result = string.Join(", ",(userInput.ToArray()));
        //     Assert.AreEqual("raining, today", result);
        // }

    }
}