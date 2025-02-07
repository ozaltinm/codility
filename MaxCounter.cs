using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public int[] solution(int N, int[] A) {
        int l = A.Length;
        int [] result = new int [N];
        int maxCounter=0;                
        for (int i=0; i<l; i++)
        {
           if (A[i]>=1 && A[i]<=N)        
             {   
                result[A[i]-1] +=1;
                if ((result[A[i]-1]) > maxCounter)    
                     maxCounter = result[A[i]-1];        
             }
           if (A[i] == N+1)
            {                          
             for (int j=0; j<N; j++) result[j] = maxCounter;              
            }            
        }
        return result;        
    }

}
