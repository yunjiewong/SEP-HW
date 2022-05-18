using System;
namespace Assignment2
{
	public class RotationArray
	{
       public void rotateArrayAndSum(int[] array, int rotate)
        {
            int n = array.Length;
            int[] b = new int[n];
            for(int i = rotate+1; i > 1; i--)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(array[(j + i) % n] + " ");
                    b[j] += array[(j + i) % n];
                }
                Console.WriteLine();

            }
            
            for(int i = 0; i < n; i++)
            {
                Console.Write(b[i] +" ");
            }
            Console.WriteLine();
        }
    }

}
