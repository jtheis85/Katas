using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace ArrayQuicksortKata
{
  [TestClass]
  public class QuicksortTests
  {
    [TestMethod]
    public void Quicksort_EmptyArray_ReturnsEmptyArray()
    {
      var input = new int[0];
      Sorter.Quicksort(input).Should().BeEmpty();
    }

    [TestMethod]
    public void Quicksort_SingleElementArray_ReturnsArray()
    {
      var input = new int[] { 1 };
      Sorter.Quicksort(input).Should().BeInAscendingOrder();
      Sorter.Quicksort(input).Length.Should().Be(1);
    }

    [TestMethod]
    public void Quicksort_TwoElementArray_ReturnsOrderedElements()
    {
      var input = new int[] { 2, 1 };
      Sorter.Quicksort(input).Should().BeInAscendingOrder();
      Sorter.Quicksort(input).Length.Should().Be(2);
    }

    [TestMethod]
    public void Quicksort_ManyElementArray_ReturnsOrderedElements()
    {
      var input = new int[] { 2, 1 , 10, 3, 13, 5, 5, 2, 45, 11, 6, 6, 5, 6, 1, 2, 3, 4, 2, 1, 8};
      Sorter.Quicksort(input).Should().BeInAscendingOrder();
      Sorter.Quicksort(input).Length.Should().Be(21);
    }
  }
}
