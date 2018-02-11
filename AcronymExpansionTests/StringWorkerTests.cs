using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AcronymExpansion;

namespace AcronymExpansionTests
{
    [TestClass]
    public class StringWorkerTests
    {
        [TestMethod]
        public void ReplaceAcronyms_test_1()
        {
            //arrange
            Dictionary<string, string> acronyms = DictionaryOfAcronyms.Dictionary();
            string actual = "gllol, hf all";
            string expected = "gllol, have fun all";

            //act
            actual = StringWorker.ReplaceAcronyms(actual);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaceAcronym_test_1()
        {
            //arrange
            KeyValuePair<string, string> acronym = new KeyValuePair<string, string>("lol", "laugh out loud");
            string actual = "lol, thats funny";
            string expected = "laugh out loud, thats funny";

            //act
            actual = StringWorker.ReplaceAcronym(actual, 0, acronym);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
