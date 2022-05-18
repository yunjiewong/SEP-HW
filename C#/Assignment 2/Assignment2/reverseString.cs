using System;
namespace Assignment2
{
	public class reverseString
	{
        public reverseString(){
            string input = Console.ReadLine();
           
            for(int i = input.Length-1; i >= 0; i--){
                Console.Write(input[i]);
            }


            char[] ch = new char[input.Length]; 

            Console.WriteLine();
            // Copy character by character into array 
            for (int i = 0; i < input.Length; i++) { 
                ch[i] = input[i]; 
            } 

            Array.Reverse(ch);

            string output = string.Concat(ch);


            Console.WriteLine(output);
        }
    }
}