using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldKata
{
  public static class Powers
  {
    public static IEnumerable<int> Power(int baseNum, int exponent)
    {
      return GetPowers(baseNum, exponent).ToList();
    }

    private static IEnumerable<int> GetPowers(int baseNum, int exponent)
    {
      int result = 1;

      for (int i = 1; i <= exponent; i++)
      {
        result *= baseNum;
        yield return result;
      }
    }
  }
}
