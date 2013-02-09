using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceKata
{
  [TestClass]
  public class AnimalTests
  {
    [TestMethod]
    public void Speak_Animal_AnimalNoises()
    {
      var animal = new Animal();
      animal.Speak().Should().Be("Animal noises");
    }

    [TestMethod]
    public void Speak_Dog_Bark()
    {
      var dog = new Dog();
      dog.Speak().Should().Be("Bark");
      dog.MakeAnimalNoises().Should().Be("Animal noises");
    }

    [TestMethod]
    public void Speak_Chihuahua_YipYip()
    {
      var chihuahua = new Chihuahua();
      chihuahua.Speak().Should().Be("Bark Yip yip");
      chihuahua.MakeAnimalNoises().Should().Be("Animal noises");
    }

    [TestMethod]
    public void Speak_Animals_Cacophony()
    {
      var animals = new List<Animal>() 
      {
        new Animal(),
        new Dog(),
        new Chihuahua()
      };

      animals.Select(animal => animal.Speak()).Should().ContainInOrder(new List<string>() {"Animal noises", "Bark", "Bark Yip yip"});
    }

    [TestMethod]
    public void Speak_Robot_Binary()
    {
      var robot = new Robot();
      robot.Speak().Should().Be("01011100");
    }

    [TestMethod]
    public void Speak_Things_Cacophony()
    {
      var things = new List<Thing>() 
      {
        new Animal(),
        new Dog(),
        new Chihuahua(),
        new Robot()
      };

      things.Select(thing => thing.Speak()).Should().ContainInOrder(new List<string>() { "Animal noises", "Bark", "Bark Yip yip", "01011100" });
    }
  }
}
