class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int max=0;
        int lengthA = A.Length;
        int [] peaks = new int[lengthA];
        int p=0;
        for(int i=1; i<lengthA-1; i++)
        {
            if(A[i]>A[i-1]&&A[i]>A[i+1])
            {
                peaks[p]=i;
                p++;
                max++;
            }
        }
        for(int i=0;i<p-1;i++){
            if(peaks[i+1]-peaks[i]<=max){
                max--;
                peaks[i+1]=peaks[i];
            }
        }
        
        return max;
    }
}
