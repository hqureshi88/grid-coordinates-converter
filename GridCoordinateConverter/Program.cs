// An entity in a game is located at coordinates (x,y) in a world measuring 1000m by 1000m. (0<=x<1000, 0<=y<1000)
// This world is divided into a 10 by 10 grid, and the grid squares are indexed from zero. Also, the x grid coordinate is converted to a letter(A, B, C).
// Implement a function Convert (x,y) that returns a string of the x grid-coordinate expressed as a letter, and the y co-ordinate as a numver between 1 and 10.
// We expect that x=0, y=0 would be "A1" and x=999, y=999 would be "J10"

using System;
using System.IO;
using System.Collections.Generic;


namespace gridConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			Answer test = new Answer();
			test.Convert(999, 999);
			test.Convert(0, 0);
			test.Convert(21, 463);
			test.Convert(1001, 1001);
		}
	}

	public class Answer
	{
		public void Convert(float x, float y)
		{

			var myGridCoord = new List<KeyValuePair<string, int>>()
			{
				new KeyValuePair<string, int>("A", 100),
				new KeyValuePair<string, int>("B", 200),
				new KeyValuePair<string, int>("C", 300),
				new KeyValuePair<string, int>("D", 400),
				new KeyValuePair<string, int>("E", 500),
				new KeyValuePair<string, int>("F", 600),
				new KeyValuePair<string, int>("G", 700),
				new KeyValuePair<string, int>("H", 800),
				new KeyValuePair<string, int>("I", 900),
				new KeyValuePair<string, int>("J", 1000),
			};

			if (x >= 1000 || y >= 1000)
			{
				Console.WriteLine("Invalid coordinates!");

			}
			else
			{
				string xCoord = "";
				float yCoord = 0;
				//loop for x coord
				foreach (KeyValuePair<string, int> val in myGridCoord)
				{
					if (x <= val.Value)
					{
						xCoord = val.Key;
						break;
					}

				}
				//loop for y-coord
				foreach (KeyValuePair<string, int> val in myGridCoord)
				{
					if (y <= val.Value)
					{
						yCoord = myGridCoord.IndexOf(val) + 1;
						break;
					}

				}
				string convertedCoord = xCoord + yCoord.ToString();

				Console.WriteLine(convertedCoord);
			}

		}
	}

}
