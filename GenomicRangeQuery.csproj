using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
         int M;
        M = P.Length;
        string subS;
        int [] result = new int [M];
        for (int i=0; i < M; i++){
            subS = S.Substring(P[i],Q[i]-P[i]+1);
            if(subS.Contains("A")){
                result[i] = 1;
            }
            else if(subS.Contains("C")){
                result[i] = 2;
            }
            else if(subS.Contains("G")){
                result[i] = 3;
            }
            else if(subS.Contains("T")){
                result[i] = 4;
            }
        }
        return result;
        
    }
}
