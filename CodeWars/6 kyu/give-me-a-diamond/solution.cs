using System;
using System.Text;
using System.Linq;

public class Diamond {
	public static string print(int n) {
    if(n < 1 || n%2==0) { return null; } // Early exit if below 0 or even

    var diamondHat = Enumerable.Range(0, n/2).Select(i => $"{new String(' ', (n/2)-i)}{new String('*', (2*i)+1)}\n"); // * triangle

    string output = $"{string.Join("", diamondHat)}" +          // top triangle
                    $"{new String('*', n)}\n" +                     // center
                    $"{string.Join("", diamondHat.Reverse())}"; // bottom triangle

    return output;
	}
}