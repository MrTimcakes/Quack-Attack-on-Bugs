using System;
using System.Linq;
using System.Collections.Generic;

public class Kata {
  public static int[] MoveZeroes(int[] arr) {
    return arr.Where(e => e != 0).Concat(Enumerable.Repeat(0, arr.Count(x => x == 0))).ToArray();
  }
}
