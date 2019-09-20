using System;

namespace _6._Middle_Characters
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			PrintMiddleCharacterOfString(input);

		}

		static void PrintMiddleCharacterOfString(string input)
		{
			//int halfLength = input.Length / 2;

			if (input.Length % 2 != 0)
			{
				Console.WriteLine(input[input.Length / 2]);
			}
			else
			{
				Console.Write(input[(input.Length / 2) - 1]);
				Console.Write(input[(input.Length / 2)]);
				Console.WriteLine();
			}
		}
	}
}
