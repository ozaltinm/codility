using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
       int passing=0;
       int counterEast=0;
       for(int i=0; i<A.Length; i++){
           if(A[i]==0) counterEast++;
           else passing += counterEast;
       }
       if(passing<0 || passing > 1e9) return -1;
       
       return passing;
       
      
    }
}
