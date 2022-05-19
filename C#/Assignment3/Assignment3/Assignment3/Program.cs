using System;

namespace Assignment3

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num = 8;
            int[] numbers = GenerateNumbers(num);
            Reverse(numbers);
            PrintNumbers(numbers);
            //Array.ForEach(numbers, Console.WriteLine);
            //Console.WriteLine(String.Join(" ", numbers));

            var f = new Fibonacci(10);



            
        }

        static int[] GenerateNumbers(int num)
        {
            int[] numbers = new int[num];
            for (int i = 0; i <num; i++) {
                numbers[i] = i + 1;
            }
            return numbers;
        }

        static void Reverse(params int[] num)
        {
            int n = num.Length-1;
            int mid = (int)(num.Length/2);
            //reverse part
            for(int i = 0; i < mid; i++)
            {
                int temp = num[i];
                num[i] = num[n - i];
                num[n - i] = temp;
            }
        }

        static void PrintNumbers(params int[] nums){
            int n = nums.Length - 1;
            for (int i = 0; i < n; i++) 
            {
                Console.Write(nums[i] + ",");
            }

            Console.Write(nums[n] + "\n");
        }

    }
}


