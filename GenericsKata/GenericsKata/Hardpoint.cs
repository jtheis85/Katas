using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsKata
{
    public class Hardpoint<T> where T : IEquipment
    {
      public T Item { get; set; }

      public string GetInfo()
      {
        return Item.Info;
      }
    }
}
