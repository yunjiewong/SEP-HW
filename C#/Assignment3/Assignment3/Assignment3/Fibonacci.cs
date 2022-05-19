using System;

namespace Assignment3

{
    public class Fibonacci
    {
        public Fibonacci(int i ){
            if (i< 1)
                System.Environment.Exit(0); 
        
            double[] dp = new double[i+1];
           
            Console.WriteLine( i+" position in Fibonacci is: " + Fibonacci_helper(dp, i));
        }
        double Fibonacci_helper(double[] dp, int n)
        {   
            //base case !!!
            if(n == 0 || n ==1){
                return n;
            }

            if (dp[n] != 0)
                return dp[n];
            
            dp[n] = Fibonacci_helper(dp, n-1)+ Fibonacci_helper(dp, n-2);
            return dp[n];
        }
    }
}