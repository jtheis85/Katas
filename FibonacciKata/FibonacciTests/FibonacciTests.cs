using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciKata
{
  [TestClass]
  public class FibonacciTests
  {
    [TestMethod]
    public void GetFibonacciNumber_N_NthFibonacciNumber()
    {
      Fibonacci.GetNth(1).Should().Be(0);
      Fibonacci.GetNth(2).Should().Be(1);
      Fibonacci.GetNth(3).Should().Be(1);
      Fibonacci.GetNth(4).Should().Be(2);
      Fibonacci.GetNth(8).Should().Be(13);
      Fibonacci.GetNth(12).Should().Be(89);
    }

    [TestMethod]
    public void GetFibonnacciSequence_N_FibonacciNumbersUpToN()
    {
      Fibonacci.GetSequence(12).Should().ContainInOrder(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 });
    }
  }
}
