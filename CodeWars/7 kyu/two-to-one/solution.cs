using System;                           // For Console.WriteLine
using System.Linq;                      // For Linq
using System.Collections.Generic;       // For Lists

public class TwoToOne {
	public static string Longest (string s1, string s2) {
    return string.Join("", $"{s1}{s2}".Distinct().OrderBy(c => c));
  }
}