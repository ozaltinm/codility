using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length<3) return 0;
        
        Array.Sort(A);
        for(int i=0;i<A.Length-2;i++){
            long x = A[i+2]-A[i+1];
            if(A[i]>x) return 1;
        }
        return 0;
    }
}
