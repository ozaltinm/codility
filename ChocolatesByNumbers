class Solution {
    public int solution(int N, int M) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
     // these already have a known answer
    if (M == 1) return N;
    if (M == N) return 1;

    int a = N, b = M;
    while (b != 0)
    {
        var temp = b;
        b = a % b;
        a = temp;
    }

    return N / a;
    }
}

