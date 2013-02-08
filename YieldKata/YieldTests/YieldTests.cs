using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YieldKata
{
  [TestClass]
  public class YieldTests
  {
    [TestMethod]
    public void Power_Base2Exponent13_ReturnListOfPowers()
    {
      Powers.Power(2, 13).Should().ContainInOrder(new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192 });
    }
  }
}
