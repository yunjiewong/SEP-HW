using System;
namespace Assignment2
{
	public class FindPrime
	{

		public static bool isPrime(int number)
        {
			if (number < 2)
				return false;

			for (int i = 2; i < number; i++)
            {
				if (number % i == 0)
                {
					return false;
                }
            }
			return true;
        }

    
        public static int[] FindPrimesInRange(int startNum, int endNum)
		{
			int[] res = new int[endNum - startNum];
			int index = 0;
			for (int i = startNum; i <= endNum; i++)
            {
				if (isPrime(i))
					res[index++] = i;
	
            }
			int[] ans = new int[index];
			Array.Copy(res, ans, index);

			return ans;
		}
	}
}

