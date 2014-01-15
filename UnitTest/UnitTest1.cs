using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uyghurdev;

namespace UnitTest
{
    [TestClass]
    public class UyghurTokenizerLibraryTest
    {
        [TestMethod]
        public void Tokenize_withNullOrEmpty_Empty()
        {
            UyghurTokenizer tokenizer = new UyghurTokenizer();
            string inputEmpty = string.Empty;
            string inputNull = null;

            string[] expectedResult = new string[] { };

            string[] actualResutl1 = tokenizer.GetTokens(inputEmpty);
            string[] actualResult2 = tokenizer.GetTokens(inputNull);

            Assert.AreNotEqual(null, actualResutl1);
            Assert.AreNotEqual(null, actualResult2);

            Assert.AreEqual(expectedResult.Length, actualResutl1.Length);
            Assert.AreEqual(expectedResult.Length, actualResult2.Length);
        }

        [TestMethod]
        public void Tokenize_withPureUyghur_UyghurWords()
        {
            UyghurTokenizer tokenizer = new UyghurTokenizer();
            string input = "بۇ بىر سىناق";
            string[] expectedResult = new string[] { "بۇ", "بىر", "سىناق" };
            string[] actualResult = tokenizer.GetTokens(input);

            Assert.AreEqual(expectedResult.Length, actualResult.Length);

            for (int i = 0; i < expectedResult.Length; i++)
                Assert.AreEqual(expectedResult[i], actualResult[i]);
        }

        [TestMethod]
        public void Tokenize_withMixedUyghur_UyghurWords()
        {
            UyghurTokenizer tokenizer = new UyghurTokenizer();
            string input = "this بۇ is a  بىر test سىناق.";
            string[] expectedResult = new string[] { "بۇ", "بىر", "سىناق" };
            string[] actualResult = tokenizer.GetTokens(input);

            Assert.AreEqual(expectedResult.Length, actualResult.Length);

            for (int i = 0; i < expectedResult.Length; i++)
                Assert.AreEqual(expectedResult[i], actualResult[i]);
        }

        [TestMethod]
        public void Tokenize_withNonUyghur_Empty()
        {
            UyghurTokenizer tokenizer = new UyghurTokenizer();
            string input = "this is a test.";
            string[] expectedResult = new string[] { };
            string[] actualResult = tokenizer.GetTokens(input);

            Assert.AreNotEqual(null, actualResult);
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
        }
    }
}
