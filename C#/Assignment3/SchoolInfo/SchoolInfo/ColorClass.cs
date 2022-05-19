using System;
namespace SchoolInfo
{
	public class ColorClass
	{
		int Red { set; get; }
		int Blue { set; get; }
		int Green { set; get; }
		int Alpha { set; get; }
		public ColorClass(int red, int green, int blue, int alpha = 255)
		{
			Red = red;
			Blue = blue;
			Green = green;
			Alpha = alpha;
		}
		public int GetGray()
        {
			return (int)((Red + Green + Blue) / 3);

        }

	}
}


/*
 
 Blue class is as easy as this 
 */