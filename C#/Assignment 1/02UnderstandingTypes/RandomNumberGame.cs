using System;
using System.IO;
namespace _02UnderstandingTypes
{
	public class RandomNumberGame
	{
		public void RandomNumber()
		{
			int correctNumber = new Random().Next(3) + 1;

			Console.Write("\n Guess a number between 1-3: ");
			int guessedNumber = int.Parse(Console.ReadLine());

			if (guessedNumber < 1 || guessedNumber > 3)
			{
				Console.WriteLine(" outside of the range of numbers that are valid guesses");
			}
			else if (guessedNumber > correctNumber)
			{
				Console.WriteLine("You guess high");

			}
			else if (guessedNumber < correctNumber)
			{
				Console.WriteLine("You guess low");
			}
			else
			{
				Console.WriteLine("You guess correct!!");
			}

		}
	}
}


