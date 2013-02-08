using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableKata
{
    public class Storage
    {
      private Hashtable hash = new Hashtable();

      public void Store(int key, object item)
      {
        hash.Add(key, item);
      }

      public object Retrieve(int key)
      {
        return hash[key];
      }

      public bool Has(params object[] items)
      {
        bool hasAllItems = true;

        foreach (var item in items)
        {
          hasAllItems &= hash.ContainsValue(item);
        }

        return hasAllItems;
      }

      public bool FunctionalHas(IEnumerable<object> items)
      {
        return items.All(item => hash.ContainsValue(item));
      }

      public string GetString(int key)
      {
        return hash[key] as string;
      }
    }
}
