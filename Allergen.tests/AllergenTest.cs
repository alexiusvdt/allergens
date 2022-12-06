using Microsoft.VisualStudio.TestTools.UnitTesting;
using Words;

namespace Words.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsNotPalindrome_True()
    {
      Assert.AreEqual(false, Palindrome.IsPalindrome("Cookie"));
    }
    [TestMethod]
    public void IsPalindrome_True()
    {
      Assert.AreEqual(true, Palindrome.IsPalindrome("bob"));
      Assert.AreEqual(true, Palindrome.IsPalindrome("catac"));
      Assert.AreEqual(true, Palindrome.IsPalindrome("dud"));
      Assert.AreEqual(true, Palindrome.IsPalindrome("bonenob"));
    }
  }
}