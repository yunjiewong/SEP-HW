using System;
namespace _02UnderstandingTypes
{
	public class Print_a_PyramidGame
	{
		public void Pyramid(int s)
		{
            for (int i = 1; i <= s; i++)
            {
                int star = i * 2 - 1;
                int space = s - i;

                for (int o = 0; o < space; o++)
                {
                    Console.Write(" ");
                }
                for (int o = 0; o < star; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
	}
}

