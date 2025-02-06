// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in Java SE 8
        if(A.length==0) return 0;
        int minNum=A[0];
        int profit=0;
        int candidate=0;
        for(int i=0;i<A.length;i++){
            if(minNum>A[i]) minNum=A[i];
            candidate=A[i]-minNum;
            if(candidate>profit) profit=candidate;
        }
        return profit;
        
    }
}
