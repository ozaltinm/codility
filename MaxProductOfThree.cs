using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int temp;
        for(int i=0; i<A.Length-1; i++){
            for(int j=i; j<A.Length; j++){
                if(A[i]>A[j]){
                    temp=A[i];
                    A[i]=A[j];
                    A[j]=temp;
                }
            }
        }
        
        int max = A[A.Length-1]*A[A.Length-2]*A[A.Length-3];
        if(A[1]<0) max = Math.Max(A[0]*A[1]*A[A.Length-1],max);
        return max;
    }
}
