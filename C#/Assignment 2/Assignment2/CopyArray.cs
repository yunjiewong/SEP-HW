using System;
namespace Assignment2
{
	public class CopyArray
	{
		public CopyArray()
		{
			int[] a1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] a2 = new int[a1.Length];

			for(int i = 0; i < a1.Length; i++)
            {
				a2[i] = a1[i];
            }

			foreach(int i in a1)
            {
				Console.Write(i + " ");
            }
			Console.WriteLine();

			foreach (int i in a2)
			{
				Console.Write(i + " ");
			}
		}
	}
}

