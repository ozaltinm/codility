using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length<X) return -1;
        if (A.Length == 1){
            if(X == 1 && A[0] == 1) return 0;
            else return -1;
        } 
        int[] B = new int[X+1];
        int counter=0;
        for(int i=0; i<A.Length; i++){
            if(A[i]<=X && B[A[i]] != 1){
                B[A[i]]=1;
                counter++;
            }
            if(counter>=X) return i;
            
        }
        return -1;
        
    }
}
