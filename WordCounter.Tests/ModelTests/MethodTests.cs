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
            string userInputWord = "Raining";
            string result = userInputWord.ToLower();
            Assert.AreEqual("raining", result);
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
    }
}