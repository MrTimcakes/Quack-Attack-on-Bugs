using System;
using System.Linq;
using System.Collections.Generic;

public class Kata {
  public static string DuplicateEncode(string word) {
    var charCounts = word.ToLower().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count()); // Create dictionary of chars and their occurance #
    string result = string.Join("", word.ToLower().Select(c => charCounts[c] == 1 ? "(" : ")")); // For each char, Unique == ( else )
    
    return result;
  }
}