using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciKata
{
  public static class Fibonacci
  {
    public static int GetNth(int n)
    {
      return GetFib(n);
    }

    private static int GetFib(int n)
    {
      if (n == 1)
      {
        return 0;
      }
      if (n == 2)
      {
        return 1;
      }

      return GetFib(n - 1) + GetFib(n - 2);
    }

    public static IEnumerable<int> GetSequence(int n)
    {
      var sequence = new List<int>();

      for (int i = 1; i <= n; i++)
      {
        sequence.Add(GetFib(i));
      }

      return sequence;
    }
  }
}
