using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int counter;
        counter= 0;
         for(int i=0; i<A.Length; i++){
             for(int j=i+1; j<A.Length; j++){
                 if(B[i]>B[j]){
                     if(A[i]>A[j]){
                         A[j]=0;
                     }else{
                         A[i]=0;
                     }
                     counter++;
                 }
             }
         }
         return A.Length - counter;
         
    }
}
