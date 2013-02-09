using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace ExtensionMethodKata
{
  [TestClass]
  public class ArrayExtensionsTests
  {
    [TestMethod]
    public void ConcatTest()
    {
      var first = new int[] { 1, 2, 3, 4 };
      var second = new int[] { 5, 6, 7, 8 };

      first.Concat(second).Should().ContainInOrder(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
    }
  }
}
