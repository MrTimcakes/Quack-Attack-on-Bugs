using System;
using System.Linq;

public static class Kata {
  public static string[] Capitalize(string s) {
    var even = s.Select((c, index) => (index % 2 == 0) ? char.ToUpper(c) : char.ToLower(c));
    var odd  = s.Select((c, index) => (index % 2 != 0) ? char.ToUpper(c) : char.ToLower(c));

    return new string[] {string.Join("", even), string.Join("", odd)};
  }
}