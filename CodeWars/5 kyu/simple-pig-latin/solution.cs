using System;
using System.Linq;

public class Kata {
  public static string PigIt(string str) {
    return string.Join(" ", str.Split(" ").Select(i => char.IsPunctuation(i[0]) ? i : $"{i[1..]}{i[0]}ay"));
  }
}