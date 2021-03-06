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
			//set up iterable key value list
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

			// statement ensures coordinates are within 1000 by 1000
			if (x >= 1000 || y >= 1000)
			{
				Console.WriteLine("Invalid coordinates!");

			}
			else
			{
				//declare and initialise variables for coordinate conversion
				string xCoord = "";
				float yCoord = 0;
				//loop for x coord
				
				//iterate through coordinate x to match suitable letter from myGridCoord List
				foreach (KeyValuePair<string, int> val in myGridCoord)
				{
					if (x <= val.Value)
					{
						xCoord = val.Key;
						break;
					}

				}
				//loop for y-coord to match suitable key value pair from myGridCoord list and find the index value
				foreach (KeyValuePair<string, int> val in myGridCoord)
				{
					if (y <= val.Value)
					{
						yCoord = myGridCoord.IndexOf(val) + 1;
						break;
					}

				}
				string convertedCoord = xCoord + yCoord.ToString();

				//print results out as string for converted coordinates
				Console.WriteLine(convertedCoord);
			}

		}
	}

}
