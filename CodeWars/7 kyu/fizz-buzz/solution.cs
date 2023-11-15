using System;
using System.Linq;

public class FizzBuzz {
	public static string[] GetFizzBuzzArray(int n) {
    return Enumerable.Range(1, n).Select( i =>
                                          i % 15 == 0 ? "FizzBuzz" : 
                                          i % 3 == 0 ? "Fizz" : 
                                          i % 5 == 0 ? "Buzz" : 
                                          i.ToString() ).ToArray();
	}
}