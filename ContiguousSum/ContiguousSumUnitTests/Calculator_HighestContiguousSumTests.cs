using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using HighestContiguousSum;

namespace HighestContiguousSumUnitTests
{
  [TestClass]
  public class Calculator_HighestContiguousSumTests
  {
    [TestMethod]
    public void HighestContiguousSum_OfEmptyArray_ReturnsNull()
    {
      var inputArray = new int[0];
      Calculator.HighestContiguousSum(inputArray).Should().Be(null);
    }

    [TestMethod]
    public void HighestContiguousSum_OfSingleElementArray_ReturnsElement()
    {
      var inputArray = new int[1];
      Calculator.HighestContiguousSum(inputArray).Should().Be(inputArray[0]);
    }

    [TestMethod]
    public void HighestContigiousSum_OfNegativeAndPositive_ReturnsPositive()
    {
      var inputArray = new int[] { -1, 1 };
      Calculator.HighestContiguousSum(inputArray).Should().Be(1);
    }

    [TestMethod]
    public void HighestContiguousSum_OfNegativeValues_ReturnsLeastNegativeValue()
    {
      var inputArray = new int[] { -3, -2 };
      Calculator.HighestContiguousSum(inputArray).Should().Be(-2);
    }

    [TestMethod]
    public void HighestContiguousSum_OfNonNegativeValues_ReturnsSumOfValues()
    {
      var inputArray = new int[] { 1, 2, 0, 4};
      Calculator.HighestContiguousSum(inputArray).Should().Be(7);
    }

    [TestMethod]
    public void HighestContiguousSum_OfNegativeSplit_ReturnsBestSide()
    {
      var inputArray = new int[] { 2, -3, 3 };
      Calculator.HighestContiguousSum(inputArray).Should().Be(3);
    }

    [TestMethod]
    public void HighestContiguousSum_OfIncludedNegative_ReturnsSumWithNegative()
    {
      var inputArray = new int[] { 2, -1, 2 };
      Calculator.HighestContiguousSum(inputArray).Should().Be(3);
    }

    [TestMethod]
    public void HighestContiguousSum_OfThreeSections_ReturnsBestSection()
    {
      var inputArray = new int[] { 5, -2, 1, -4, 4 };
      Calculator.HighestContiguousSum(inputArray).Should().Be(5);
    }

    [TestMethod]
    public void HighestContiguousSum_WithMultipleNegatives_ReturnsSumWithoutNegatives()
    {
      var inputArray = new int[] { -1, -1, 1, 2, -1, -1, -1, 2, -1, -1, -1};
      Calculator.HighestContiguousSum(inputArray).Should().Be(3);
    }

    [TestMethod]
    public void HighestContiguousSum_AllNegative_ReturnsTheLeastNegative()
    {
      var inputArray = new int[] { -8, -3, -4, -1, -2, -1, -5, -7 };
      Calculator.HighestContiguousSum(inputArray).Should().Be(-1);
    }

    [TestMethod]
    public void HighestContiguousSum_CommunitySubmission_1()
    {
      var inputArray = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
      Calculator.HighestContiguousSum(inputArray).Should().Be(7);
    }
  }
}
