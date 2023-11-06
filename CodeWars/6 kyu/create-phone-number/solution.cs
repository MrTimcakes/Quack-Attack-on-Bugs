public class Kata {
  public static string CreatePhoneNumber(int[] numbers) {
    return string.Format("({0}) {1}-{2}", 
      string.Join("", numbers[..3]), 
      string.Join("", numbers[3..6]), 
      string.Join("", numbers[6..]));
  }
}