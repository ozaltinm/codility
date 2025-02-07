class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        bool flag1 = false;
        int counter=0;
        int max = 0;
        if(N==1) return 0;
        
        while(N>1){
            if( N % 2 == 1) {
                flag1 = true;
                max = Math.Max(max, counter);
                counter = 0;
            }
            else if( flag1 == true){
                counter++;
            }
            N=N/2;
        }
        max = Math.Max(max, counter);
        return max;
        
    }
}

