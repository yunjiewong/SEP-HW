using System;
namespace _02UnderstandingTypes
{
	public class FizzBuzz
	{
		public void FizzBuzzGame(int i)
		{
			Console.WriteLine("\nFizzBuzzGame: \n");
			for (int j = 1; j <= i; j++)
            {
				if (j % 15 == 0)
				{
					Console.WriteLine("FizzBuzz");
					continue;
				}
				else if (j % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (j % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
                else
                {
					Console.WriteLine(j);
				}
            }
		}
	}
}

