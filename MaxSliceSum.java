class Solution {
    public int solution(int[] A) {
        // write your code in Java SE 8
        int maxSlice=A[0];
        int candidateMax=A[0];
        for(int i=1;i<A.length;i++){
            candidateMax=Math.max(A[i],candidateMax+A[i]);
            maxSlice=Math.max(maxSlice, candidateMax);
        }
        return maxSlice;
        
    }
}
