using System;
using System.Linq;
using System.Collections.Generic;

class Kata {
  public static int[] FirstNSmallest(int[] arr, int n) {
    return arr
      .Select((val, index) => new { Value = val, Index = index }) // Associate each element with its index
      .OrderBy(pair => pair.Value)                                // Sort elements by their values in ascending order
      .Take(n)                                                    // Take the first N elements
      .OrderBy(pair => pair.Index)                                // Sort the result by the original indices to maintain the original order
      .Select(pair => pair.Value)                                 // Select just the values (Not value, index pairs)
      .ToArray();
  }
}