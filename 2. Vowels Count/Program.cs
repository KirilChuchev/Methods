using System;
using System.Linq;

namespace _2._Vowels_Count
{
	class Program
	{
	

		static void Main(string[] args)
		{
			PrintVowelsInAStringFromConsole();
		}

		private static void PrintVowelsInAStringFromConsole()
		{
			string input = Console.ReadLine();

			input = input.ToUpper();

			int counter = 0;

			char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

			for (int i = 0; i < input.Length; i++)
			{
				if (vowels.Contains(input[i]))
				{
					counter++;
				}
			}

			Console.WriteLine(counter);
		}

	}
}
