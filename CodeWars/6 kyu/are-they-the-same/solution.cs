using System;
using System.Linq;

class AreTheySame{
   public static bool comp(int[] a, int[] b) {
    // Check if either of the arrays is null or their lengths are different
    if (a == null || b == null || a.Length != b.Length) { return false; }

    // Sort both arrays
    Array.Sort(a);
    Array.Sort(b);

    // Pairwise check if A*A == B, then check all elements are true else return false
    return a.Zip(b, (itemA, itemB) => itemA * itemA == itemB).All(isSquare => isSquare); 
  }
}