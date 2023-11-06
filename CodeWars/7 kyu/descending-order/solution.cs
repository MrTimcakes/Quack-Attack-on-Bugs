using System;
using System.Linq;

public static class Kata {
  public static int DescendingOrder(int num) {
    var digits = num.ToString().Select(d => Int32.Parse(d.ToString())).OrderByDescending(i=>i).ToList();
    return int.Parse(string.Join("", digits));
  }
}