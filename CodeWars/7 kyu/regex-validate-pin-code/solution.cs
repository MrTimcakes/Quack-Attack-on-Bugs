using System;
using System.Linq;

public class Kata {
  public static bool ValidatePin(string pin) {
    return pin.All(char.IsDigit) && pin.Length is 4 or 6;
  }
}