using System;
using System.Linq;

public class Scramblies  {
  public static bool Scramble(string str1, string str2) {
    return str2.All(c => str1.Count(x => x == c) >= str2.Count(x => x == c)); // Ensure all characters in str2 are in str1, and ensure str1 contains atleast as many occurances
  }
}