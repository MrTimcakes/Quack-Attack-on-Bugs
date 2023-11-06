using System.Linq;

public class DnaStrand {
  public static string MakeComplement(string dna) {
    return string.Join("", dna.Select(r => r switch {
      'A' => 'T',
      'T' => 'A',
      'C' => 'G',
      'G' => 'C'
    }).ToList());
  }
}