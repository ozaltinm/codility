using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length==0) return 1;
        Array.Sort(A);
        int i=0;
        for(i=0;i<A.Length;i++){
            if(A[i]!=i+1) return i+1;
        }
        return i+1;
    }
}
