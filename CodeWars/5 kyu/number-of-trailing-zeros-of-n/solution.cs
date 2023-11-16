using System;

public static class Kata {
  public static int TrailingZeros(int n) {
    int count = 0;
    int i = 5; // Start with the divisor being 5

    while(n / i > 0) {
      count += n / i;
      i *= 5; // Increase the divisor to the next power of 5
    }
    return count;
  }
}