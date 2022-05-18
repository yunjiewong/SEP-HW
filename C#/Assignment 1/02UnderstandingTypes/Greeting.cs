using System;

namespace _02UnderstandingTypes
{
	public class Greeting
	{
		public Greeting(DateTime dt)
		{
			int i = dt.Hour;
			if (i <= 12)
				Console.WriteLine("Good Morning");
			
			 if (i <= 16 && i > 12)
				Console.WriteLine("Good Afternoon");

			 if (i <= 20 && i > 16)
				Console.WriteLine("Good Evening");
		
			if (i <= 24 && i > 20)
				Console.WriteLine("Good Night");
		   
		}
	}
}

