using System;
using System.Linq;

public static class Kata {
  public static bool IsPangram(string str) {
    var letterCount = str.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());   
    return (letterCount.Count() == 26 ? true : false);
  }
}