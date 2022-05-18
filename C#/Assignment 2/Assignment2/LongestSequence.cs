using System;
using System.Collections.Generic;
namespace Assignment2
{
	public class LongestSequence
    {
        public int[] Longest(int[] num)
        {
            if (num.Length == 0)
                return new int[0];

            int current = num[0];
            int count = 0;
            int maxNum = current;
            int maxItr = 0;
            foreach (int i in num){
                if (i == current){
                    count++;
                }
                else{
                    if(count > maxItr){
                        maxItr = count;
                        maxNum = current;
                    }
                    count = 1;
                    current = i;
                }
            }
        
            int[] ans = new int[maxItr];
            for(int i =0; i<maxItr; i++){
                ans[i] =maxNum;
            }

            return ans;



        }
    }
    

}