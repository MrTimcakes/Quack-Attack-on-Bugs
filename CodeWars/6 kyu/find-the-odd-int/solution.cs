using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution {
  class Kata {
    public static int find_it(int[] seq) {
      return seq
        .GroupBy(c => c)                          // Group identical elements
        .ToDictionary(g => g.Key, g => g.Count()) // Count group occurnaces
        .Where(pair => pair.Value % 2 != 0)       // Reduce to elements with odd counts
        .Select(pair => pair.Key)                 // Select the key of the group (The orginal element instead of the count)
        .FirstOrDefault(-1);                      // Return -1 if there are no matches
    }
  }
}