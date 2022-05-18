using System;
namespace _02UnderstandingTypes
{
	public class CountingGame
	{
		public void Counting(int value)
		{
			for(int i = 1; i <= value; i++)
            {
				for(int j= 0; j < 24; j+=i)
                {
					Console.Write(j + ",");
                }
				Console.WriteLine("24");
            }
		}
	}
}

