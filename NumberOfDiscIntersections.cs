using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int N = A.Length;
		long[] lower = new long[N];
		long[] upper = new long[N];

		for (int i = 0; i < N; i++) {
			lower[i] = i - (long) A[i];
			upper[i] = i + (long) A[i];
		}

		Array.Sort(lower);
		Array.Sort(upper);

		int intersection = 0;
		int j = 0;

		for (int i = 0; i < N; i++) {
			while (j < N && upper[i] >= lower[j]) {
				intersection += j;
				intersection -= i;
				j++;
			}
		}

		if (intersection > 10000000) return -1;
		return intersection;
    }
}
