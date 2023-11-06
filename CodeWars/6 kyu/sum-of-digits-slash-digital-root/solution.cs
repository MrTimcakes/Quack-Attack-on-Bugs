using System;
using System.Linq;

public class Number {
  public static int DigitalRoot(long n) {
    // Do
      // Split into digits
      // Add Digits
    // While 1+ digits
    // return result
    
    long result = n;
    
    do{
      var digits = result.ToString().Select(c => long.Parse(c.ToString()));
      result = digits.Sum();
    } while(result>9);
    
    return (int)result;
  }
}