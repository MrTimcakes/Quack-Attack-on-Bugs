using System;

public static class TimeFormat {
  public static string GetReadableTime(int seconds) {
    var hrs   = (int)Math.Floor( seconds/3600.0 );
    var mins  = (int)Math.Floor( (seconds%3600.0)/60.0 );
    var scnds = (int)Math.Floor( seconds - (hrs*3600.0) - (mins*60.0));
      
    return $"{hrs:D2}:{mins:D2}:{scnds:D2}";
  }
}