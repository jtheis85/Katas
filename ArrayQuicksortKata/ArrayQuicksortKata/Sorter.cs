using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuicksortKata
{
    public static class Sorter
    {
      public static int[] Quicksort(int[] input)
      {
        if (input.Length < 2)
        {
          return input;
        }

        int pivot = input[input.Length / 2];
        int[] lessThanPivot = input.Where(item => item < pivot).ToArray();
        int[] equalToPivot = input.Where(item => item == pivot).ToArray();
        int[] greaterThanPivot = input.Where(item => item > pivot).ToArray();

        int[] result = new int[input.Length];

        Quicksort(lessThanPivot).CopyTo(result,0);
        equalToPivot.CopyTo(result, lessThanPivot.Length);
        Quicksort(greaterThanPivot).CopyTo(result, lessThanPivot.Length + equalToPivot.Length);

        return result;
      }
    }
}
