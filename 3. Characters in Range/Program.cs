using System;

namespace _3._Characters_in_Range
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintAllCharsBetweenTwoCharsFromConsole();
		}

		static void PrintAllCharsBetweenTwoCharsFromConsole()
		{
			char charOne = char.Parse(Console.ReadLine());
			char charTwo = char.Parse(Console.ReadLine());

			char startChar = '\0';
			char endChar = '\0';

			if (charOne > charTwo)
			{
				startChar = charTwo;
				endChar = charOne;
			}
			else if (charOne <= charTwo)
			{
				startChar = charOne;
				endChar = charTwo;
			}

			for (char i = (char)(startChar + 1); i < endChar; i++)
			{
				Console.Write(i + " ");
			}

			Console.Write(Environment.NewLine);
		}
	}
}
