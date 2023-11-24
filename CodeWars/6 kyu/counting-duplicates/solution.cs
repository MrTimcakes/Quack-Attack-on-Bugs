using System;
using System.Linq;

public class Kata {
  public static int DuplicateCount(string str) {
    return str.ToLower()          // Case-insensitivity
      .GroupBy(c => c)            // Group by character (Count Occuurance)
      .Count(g => g.Count() > 1); // Count groups with more than one occurrence
  }
}