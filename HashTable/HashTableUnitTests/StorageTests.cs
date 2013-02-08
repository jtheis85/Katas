using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;

namespace HashTableKata
{
  [TestClass]
  public class StorageTests
  {
    [TestMethod]
    public void Store_Null_ReturnsNull()
    {
      var storage = new Storage();
      storage.Store(1, null);
      storage.Retrieve(1).Should().Be(null);
    }

    [TestMethod]
    public void Store_Int_ReturnsInt()
    {
      var storage = new Storage();
      storage.Store(1, 1);
      storage.Retrieve(1).Should().Be(1);
    }

    [TestMethod]
    public void Store_AnonymousType_ReturnsAnonymousType()
    {
      var storage = new Storage();
      var item = new { name = "Starbuck", rank = "Lieutennant", serialNumber = 1337 };
      storage.Store(1, item);
      storage.Retrieve(1).Should().Be(item);
    }

    [TestMethod]
    public void Has_MultipleItems_ReturnsTrue()
    {
      var storage = new Storage();
      storage.Store(0, 1);
      storage.Store(1, 2);
      storage.Store(2, 3);

      storage.Has(1,2,3).Should().Be(true);
      storage.FunctionalHas(new List<object>() { 1, 2, 3 }).Should().Be(true);
    }

    [TestMethod]
    public void Has_MultipleItems_ReturnsFalse()
    {
      var storage = new Storage();
      storage.Store(0, 1);
      storage.Store(1, 2);
      storage.Store(2, 3);

      storage.Has(1, 4, 3).Should().Be(false);
    }

    [TestMethod]
    public void GetString_GivenString_ReturnString()
    {
      var storage = new Storage();
      storage.Store(0, "My Item");

      storage.GetString(0).GetType().Should().Be(typeof(string));
      storage.GetString(0).Should().Be("My Item");
    }

    [TestMethod]
    public void GetString_GivenInt_ReturnsNull()
    {
      var storage = new Storage();
      storage.Store(0, 1);

      storage.GetString(0).Should().Be(null);
    }
  }
}
