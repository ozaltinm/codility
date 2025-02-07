using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int lengthA;
        int modA;
        int temp;
        lengthA = A.Length;
        modA = lengthA % K;
        if (modA == 0){
            return A;
        }else{
            for(int j=0; j<K-1; j++){
                temp = A[0];
                for(int i = 0; i < lengthA - 1; i++){
                    A[i] = A[i+1];
                }
                A[lengthA-1] = temp;
            }
            return A;
        }
        
    }
