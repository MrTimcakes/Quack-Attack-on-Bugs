using System;
using System.Linq;
using System.Collections.Generic;

public class SnailSolution {
  public static int[] Snail(int[][] array) {
    var todo = array.Select(x => x.ToList()).ToList(); // Convert to mutable nested List
    List<int> output = new(); // Store output    
     
    while( todo.Count != 0 ){
      output.AddRange(todo[0]); // Add top row
      todo.RemoveAt(0);
      
      if(todo.Count == 0) { break; } // We just added the last item
      
      foreach(var row in todo){ // Descending each row, add the last element
        output.Add(row[row.Count - 1]);
        row.RemoveAt(row.Count - 1);
      }
      
      output.AddRange(todo.Last().ToArray().Reverse()); // Add last row reversed (idk why ToArray is needed)
      todo.RemoveAt(todo.Count - 1);
      
      foreach(var row in todo.ToArray().Reverse()){ // Ascending each row, add the First element
        output.Add(row[0]);
        row.RemoveAt(0);
      }
    }
    return output.ToArray();
  }
}