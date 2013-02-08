using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeKata
{
    public static class PalindromeDetector
    {
      public static bool IsPalindrome(string input)
      {
        if (input == null)
        {
          throw new ArgumentNullException();
        }

        return input.TakeWhile((character, index) =>
          character == input.Reverse()
                            .ElementAt(index))
                            .Count() == input.Length;
      }
    }
}
