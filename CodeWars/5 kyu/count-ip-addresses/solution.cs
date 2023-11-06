using System;
using System.Linq;

public class CountIPAddresses {
   public static long IpsBetween(string start, string end) {
     var IP1 = start.Split(".").Select(i => int.Parse(i.ToString())).ToList();
     var IP2 = end.Split(".").Select(i => int.Parse(i.ToString())).ToList();

     return ((IP2[0] - IP1[0]) * (long)Math.Pow(2, 24)) +
            ((IP2[1] - IP1[1]) * (long)Math.Pow(2, 16)) +
            ((IP2[2] - IP1[2]) * (long)Math.Pow(2, 8)) +
            ((IP2[3] - IP1[3]) * (long)Math.Pow(2, 0));
   }
}