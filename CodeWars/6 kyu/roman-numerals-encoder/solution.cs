using System;
using System.Linq;

public class RomanConvert {
	public static string Solution(int n) {
    return new string('I' , n)              // Roman I * n
      .Replace(new string('I' , 1000), "M") // Replace from largest to smallest
      .Replace(new string('I' , 900), "CM")
      .Replace(new string('I' , 500), "D")
      .Replace(new string('I' , 400), "CD")
      .Replace(new string('I' , 100), "C")
      .Replace(new string('I' , 90), "XC")
      .Replace(new string('I' , 50), "L")
      .Replace(new string('I' , 40), "XL")
      .Replace(new string('I' , 10), "X")
      .Replace(new string('I' , 9), "IX")
      .Replace(new string('I' , 5), "V")
      .Replace(new string('I' , 4), "IV");
	}
}