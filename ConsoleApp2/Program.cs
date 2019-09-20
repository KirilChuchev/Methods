using System;

namespace _9._Palindrome_Integers
{
	class Program
	{
		static string IsPalindrome(int number)
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

			return isPalindrome.ToString();
		}




		static void Main(string[] args)
		{

			

			while (true)
			{
				try
				{
					int number = int.Parse(Console.ReadLine());

					string isPalindrome = IsPalindrome(number);

					Console.WriteLine(isPalindrome.ToLower());
				}
				catch (Exception)
				{
					break;
					
				}

				

				

				
			}




		}


	}
}
