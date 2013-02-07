using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestContiguousSum
{
  /// <summary>
  /// 
  /// </summary>
  public static class Calculator
  {
    /// <summary>
    /// Computes the highest contiguous sum within an array of integers.
    /// A contiguous sum is integers next to each other in the array.
    /// </summary>
    /// <example>
    /// For the array [4, 0, -5, 6, 5], the answer should be 11, because
    /// 6 and 5 are next to each other, and adding -5 would reduce the sum.
    /// </example>
    /// <param name="inputArray">An array of integers to sum</param>
    /// <returns>The sum, or null if the array was empty</returns>
    public static int? HighestContiguousSum(int[] inputArray)
    {
      // Validate input
      if (inputArray.Length == 0) { return null; }

      else
      {
        int currentSum = inputArray[0];
        int bestSum = inputArray[0];

        //Starting at the 2nd element
        for (int i = 1; i < inputArray.Length; i++)
        {
          int value = inputArray[i];
          // Take a better value if we have a negative
          if (bestSum < 0 && bestSum < value)
          {
            bestSum = value;
            currentSum = value;
          }
          else if (value > 0 || (value < 0 && value > -1 * currentSum))
          {
            currentSum += value;
            bestSum = Math.Max(currentSum, bestSum);
          }
          else if (value <= -1 * currentSum)
          {
            currentSum = 0;
          }
        }

        return bestSum;
      }
    }
  }
}
