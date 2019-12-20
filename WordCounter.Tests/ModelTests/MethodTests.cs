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
    }
}