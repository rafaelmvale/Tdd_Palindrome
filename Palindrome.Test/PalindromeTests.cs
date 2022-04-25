using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Palindrome.Logic
{
    [TestClass]
    public class PalindromeTests
    {
        Palindrome palindrome;

        [TestInitialize]
        public void SetUp()
        {
            palindrome = new Palindrome();
        }

        [TestMethod]
        public void isPalindrome_WhenStringIsPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(palindrome.isPalindrome("Rotator"));
            Assert.IsTrue(palindrome.isPalindrome("bob"));
            Assert.IsTrue(palindrome.isPalindrome("madam"));
            Assert.IsTrue(palindrome.isPalindrome("mAlAyAlam"));
            Assert.IsTrue(palindrome.isPalindrome("1"));
            Assert.IsTrue(palindrome.isPalindrome("Able was I, ere I saw Elba"));
            Assert.IsTrue(palindrome.isPalindrome("Madam I´m Adam"));
            Assert.IsTrue(palindrome.isPalindrome("Step on no pets"));
            Assert.IsTrue(palindrome.isPalindrome("Top spot!"));
            Assert.IsTrue(palindrome.isPalindrome("02/02/2020"));
        }

        [TestMethod]
        public void isPalindrome_WhenStringIsNotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(palindrome.isPalindrome("xyz"));
            Assert.IsFalse(palindrome.isPalindrome("elephant"));
            Assert.IsFalse(palindrome.isPalindrome("Country"));
            Assert.IsFalse(palindrome.isPalindrome("Top . post!"));
            Assert.IsFalse(palindrome.isPalindrome("Wonderful-fool"));
            Assert.IsFalse(palindrome.isPalindrome("Wild imagination!"));
        }
    }
}
