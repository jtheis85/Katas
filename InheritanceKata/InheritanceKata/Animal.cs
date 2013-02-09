using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceKata
{
  public abstract class Thing
  {
    public abstract string Speak();
  }

  public class Animal : Thing
  {
    public override string Speak()
    {
      return "Animal noises";
    }
  }

  public class Dog : Animal
  {
    public override string Speak()
    {
      return "Bark";
    }

    public virtual string MakeAnimalNoises()
    {
      return base.Speak();
    }
  }

  public class Chihuahua : Dog
  {
    public override string Speak()
    {
      return base.Speak() + " Yip yip";
    }

    public override string MakeAnimalNoises()
    {
      return base.MakeAnimalNoises();
    }
  }

  public class Robot : Thing
  {
    public override string Speak()
    {
      return "01011100";
    }
  }
}
