using System;                           // For Console.WriteLine
using System.Linq;                      // For Linq
using System.Collections.Generic;       // For Lists

public class SplitString {
  public static string[] Solution(string str) {
    return Enumerable.Range(0, str.Length)
      .Where(i => i % 2 == 0) // Process even pairs
      .Select(i => $"{str[i]}{(i+1 >= str.Length ? "_" : str[i+1])}")
      .ToArray();
  }
}