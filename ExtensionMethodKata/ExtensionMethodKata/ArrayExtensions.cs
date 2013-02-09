using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodKata
{
    public static class ArrayExtension
    {
      public static T[] Concat<T>(this T[] first, T[] second)
      {
        int oldLength = first.Length;
        Array.Resize(ref first, first.Length + second.Length);
        Array.Copy(second, 0, first, oldLength, second.Length);

        return first;
      }
    }
}
