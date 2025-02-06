class Solution {
    public int solution(int N) {
        // write your code in Java SE 8
        if(N==1) return 4;
        int candidate=0;
        int minPerimeter=Integer.MAX_VALUE;
        for(int i=1;i*i<=N;i++)
        {
            if(N%i==0) candidate = 2*(i + (N/i));
            if(minPerimeter>candidate) minPerimeter=candidate;
        }
        return minPerimeter;
    }
}
