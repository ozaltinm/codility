// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in Java SE 8
        int value=-1;
        int size=0;
        int leader=-1;
         int indices=0;
        for(int i=0;i<A.length;i++)
        {
            if(size==0) {value=A[i]; size++;}
            else if(A[i]!=value){size--;}
            else size++;
        }
        int candidate=-1;
        if(size>0) candidate=value;
        int count=0;
        for(int i=0;i<A.length;i++)
        {
            if(A[i]==candidate) count++;
        }
        if(count<=A.length/2) {return 0;}
        else{
            leader=candidate;
            size=0;
            for(int i=0;i<A.length;i++){
                if(A[i]==leader){
                    count--;
                    size++;
                }
                if( ( size>((i+1)/2) )&&( count>(A.length-(i+1)) /2 ) )
                    indices++;
            }
        }
        
        return indices;
    }
}
