using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int i;
        if(A.Length==1){
            if(A[0] == 1) return 2;
            else return 1;
        } 
        var B = new int[A.Length+1];
        for(i=0; i<A.Length; i++){
            if(A[i]<=A.Length && A[i]>0){
                B[A[i]] = 1;
            }
        }
        for(i=1; i<B.Length; i++)
        {
            if(B[i]!=1) return i;
        }
        return i;
    }
}
