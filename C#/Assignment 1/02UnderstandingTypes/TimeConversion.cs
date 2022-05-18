using System;

namespace _02UnderstandingTypes
{
	public class TimeConversion
	{
		public void TimeCon(int i)
		{
			//			enter an integer number of centuries and convert it to years, days, hours,
			//minutes, seconds, milliseconds, microseconds, nanoseconds.
		
			double y = i * 100;
			double d = (int) (y * 365.24);
			double h = d * 24;
			double m = h * 60;
			double s = m * 60;
			double mi = s * 1000;
			double mc = mi * 1000;
			double na = mc * 1000;
			Console.WriteLine();
			Console.WriteLine($"{i} centry = {y } year = {d} day = {h} hours = {m} " +
                $"minutes = { s} second = {mi} milliseconds = {mc} microseconds = {na}" +
                $" nanoseconds");
		}
	}
}


