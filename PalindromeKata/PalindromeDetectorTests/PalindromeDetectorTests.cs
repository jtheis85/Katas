using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeKata
{
  [TestClass]
  public class PalindromeDetectorTests
  {
    [TestMethod]
    public void IsPalindrome_NullInput_ThrowsException()
    {
      Action act = () => PalindromeDetector.IsPalindrome(null);
      act.ShouldThrow<ArgumentNullException>();
    }

    [TestMethod]
    public void IsPalindrome_EmptyString_ReturnsTrue()
    {
      PalindromeDetector.IsPalindrome("").Should().Be(true);
    }

    [TestMethod]
    public void IsPalindrome_SingleChar_ReturnsTrue()
    {
      PalindromeDetector.IsPalindrome("a").Should().Be(true);
    }

    [TestMethod]
    public void IsPalindrome_TwoDifferentChars_ReturnsFalse()
    {
      PalindromeDetector.IsPalindrome("ab").Should().Be(false);
    }

    [TestMethod]
    public void IsPalindrome_SimpleSymmetric_ReturnsTrue()
    {
      PalindromeDetector.IsPalindrome("aba").Should().Be(true);
      PalindromeDetector.IsPalindrome("abba").Should().Be(true);
      PalindromeDetector.IsPalindrome("acbbbca").Should().Be(true);
    }

    [TestMethod]
    public void IsPalindrome_WhiteSpace_ReturnsTrue()
    {
      PalindromeDetector.IsPalindrome(" ").Should().Be(true);
      PalindromeDetector.IsPalindrome("  ").Should().Be(true);
      PalindromeDetector.IsPalindrome("   ").Should().Be(true);
    }
  }
}
