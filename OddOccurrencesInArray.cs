using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int counter;
        int i,j;
        Array.Sort(A);
        for(i=0;i<A.Length;i++){
            counter=0;
            for( j=i+1; j<A.Length;j++){
                if(A[i]==A[j]) counter++;
                else break;
            }
            if(counter%2==0) return A[i];
            else i=j-1;
        }
    
        return 0;
    }
}
