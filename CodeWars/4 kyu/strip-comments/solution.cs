using System;
using System.IO;
using System.Linq;

public class StripCommentsSolution {
  public static string StripComments(string text, string[] commentSymbols) {
    string outputText = ""; // Store the output string

    // Process each line of the input
    using (var reader = new StringReader(text)) {
      for (string line = reader.ReadLine(); line != null; line = reader.ReadLine()) {
        var cmntStart = commentSymbols.Select(target => line.IndexOf(target)) // Search line for comment symbol
          .FirstOrDefault(index => index >= 0, line.Length); // Return value of first target
        
        outputText += line[..cmntStart].TrimEnd() + "\n"; // Substring from 0-cmntStart then trim whitespace, add newline
      }
      outputText = outputText[..^1]; // Remove last newline
    }

    return outputText;
  }
}