using System;
using System.Linq;
using System.Collections.Generic;

public class TopWords {
  public static List<string> Top3(string s) {
    return string.Concat(s.Select(c => char.IsPunctuation(c) && c != '\'' ? ' ' : c))      // Remove punctuation except '
      .Trim().ToLower().Split(" ")                                                         // Split into words
      .Where(word => !(word is "" or "'" or @"'''"))                                       // Exlude cases where string empty, ', or '''
      .GroupBy(word => word)                                                               // Group words
      .OrderByDescending(g=>g.Count()).ToDictionary(g => g.Key, g => g.Count())            // Sort by word occurance
      .Take(3).Select(i => i.Key).ToList();                                                // Take the top 3 hits and only select the word not the count aswell
  }
}