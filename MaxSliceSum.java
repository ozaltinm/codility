class Solution {
    public int solution(int[] A) {
        // write your code in Java SE 8
        if(A.length==1) return A[0];
        int maxSlice=Integer.MIN_VALUE;
        int candidate;
        for(int i=0;i<A.length;i++){
            candidate=A[i];
            if(maxSlice<candidate) maxSlice=candidate;
            for(int j=i+1;j<A.length;j++){
                candidate+=A[j];
                if(maxSlice<candidate) maxSlice=candidate;
            }
        }
        return maxSlice;
        
    }
}
