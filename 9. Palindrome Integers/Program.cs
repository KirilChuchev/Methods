using System;

namespace _9._Palindrome_Integers
{
	class Program
	{
		static bool IsPalindrome(int number)
		{
			string numberAsString = number.ToString();

			bool isPalindrome = true;

			for (int i = 0; i < numberAsString.Length / 2; i++)
			{
				int digitOne = numberAsString[i];
				int digitTwo = numberAsString[numberAsString.Length - 1 - i];

				if (digitOne != digitTwo)
				{
					isPalindrome = false;
				}
			}

			return isPalindrome;
		}




		static void Main(string[] args)
		{

			string input = string.Empty;

			while ((input = Console.ReadLine()) != "End")
			{
				int number = int.Parse(input);

				bool isPalindrome = IsPalindrome(number);

				Console.WriteLine(isPalindrome);
			}

			

			
		}

		
	}
}
