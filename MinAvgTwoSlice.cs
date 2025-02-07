
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    if(A.Length == 2) return (A[0]+A[1])/2;
    float min=1000000000;
    float sum=0;
    float counter=0;
    float div;
    int startPos=0;
    for(int i=0;i<A.Length-1;i++){
        sum = A[i];
        counter=1;
        for(int j=i+1;j<A.Length;j++){
            sum+=A[j];
            counter++;
            div= sum/counter;
            if(div<min) startPos=i;
            min = Math.Min(div,min);
        }
        sum=0;
    }
        return startPos;
    }
}

