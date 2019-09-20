using System;

namespace _4._Password_Validator
{
	class Program
	{
		static bool IsCountOfCharactersValid(string someString)
		{
			bool IsCountOfCharactersValid = false;
			if (someString.Length >= 6 && someString.Length <= 10)
			{
				IsCountOfCharactersValid = true;
			}

			return IsCountOfCharactersValid;
		}

		static bool IsConsistOnlyFromDigitsAndLetters(string someString)
		{

			bool IsConsistOnlyFromDigitsAndLetters = true;

			for (int i = 0; i < someString.Length; i++)
			{
				if (!char.IsLetterOrDigit(someString[i]))
				{
					IsConsistOnlyFromDigitsAndLetters = false;
				}
			}
			return IsConsistOnlyFromDigitsAndLetters;
		}

		static bool IsTheStringHaveMinTwoDigits(string someString)
		{
			bool IsTheStringHaveMinTwoDigits = false;
			int counter = 0;

			for (int i = 0; i < someString.Length; i++)
			{
				if (someString[i] >= 48 && someString[i] <= 57)
				{
					counter++;
				}

				if (counter >= 2)
				{
					IsTheStringHaveMinTwoDigits = true;
				}
			}
			return IsTheStringHaveMinTwoDigits;
		}

		static void Main(string[] args)
		{
			string password = Console.ReadLine();

			if (IsCountOfCharactersValid(password) && IsConsistOnlyFromDigitsAndLetters(password) && IsTheStringHaveMinTwoDigits(password))
			{
				Console.WriteLine("Password is valid");
			}

			if (!IsCountOfCharactersValid(password))
			{
				Console.WriteLine("Password must be between 6 and 10 characters");
			}

			if (!IsConsistOnlyFromDigitsAndLetters(password))
			{
				Console.WriteLine("Password must consist only of letters and digits");
			}

			if (!IsTheStringHaveMinTwoDigits(password))
			{
				Console.WriteLine("Password must have at least 2 digits");
			}
		}
	}
}
