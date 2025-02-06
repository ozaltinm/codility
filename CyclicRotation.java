class Solution {
    public int[] solution(int[] A, int K) {
        // write your code in Java SE 8
         // write your code in Java SE 8
         if (A.length==0){return A;}
        int B;
        int C[] = new int[A.length];
        B = K  % A.length;
        if(B != 0){
            for(int i=0; i<A.length ; i++){
                C[(i + K) % A.length] = A[i];
            }
        }else {
            return A;
        }
        
        return C;
    }
}
