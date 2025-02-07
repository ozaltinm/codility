using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int sum1 = A[0];
        int sum2 = 0;
        int min;
        for(int i=1; i < A.Length ; i++){
            sum2 += A[i];
        }
        if(A.Length == 1) return sum1;
        else if (A.Length == 2) return Math.Abs(sum1-sum2);
        else min = Math.Abs(sum1-sum2);
        for(int i=1; i<A.Length-1 ; i++){
            sum1 += A[i];
            sum2 -= A[i];
            min = Math.Min(min, Math.Abs(sum1-sum2));
        }
        
        return min;
    }
}
