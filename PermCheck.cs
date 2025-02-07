using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
     public int solution(int[] A) {
        int[] counter = new int [A.Length];
        for(int i= 0; i< A.Length; i++){
            if (A[i] < 1 || A[i] > A.Length) {
                // Out of range
                return 0;
            }
            else if(counter[A[i]-1] == 1) {
                // met before
                return 0;
            }
            else {
                // first time meet
                counter[A[i]-1] = 1;
            }
        }
        return 1;
    }
}
