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
        public void Counter_ReturnsArray_string()
        {
            string userInputWord = "ehi";
            string userSentence = "How are you doing";
            string[] result = RepeatCounter.Counter(userInputWord, userSentence);
            Assert.AreEqual({"how", "are", "you", "doing"};, result);
        }
    }
}