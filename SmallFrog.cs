using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
         if (X==Y){
            return 0;
        }else{
            int i;
            float j;
            j=(Convert.ToSingle(Y)-Convert.ToSingle(X))/Convert.ToSingle(D);
            i = Convert.ToInt32(System.Math.Ceiling(j));
            return i;
        }
    }
}
