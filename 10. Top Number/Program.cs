using System;
using System.Linq;

namespace _10._Top_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			PrintTopNumber(n);

		}

		static void PrintTopNumber(int n)
		{
			for (int number = 1; number <= n; number++)
			{

				int sumOfDigits = 0;
				int digit = int.MinValue;


				bool isDevisibleByEight = false;
				bool isSomeDigitOdd = false;

				string numberAsString = number.ToString();

				for (int j = 0; j < numberAsString.Length; j++)
				{
					sumOfDigits += int.Parse(numberAsString[j].ToString());

				}



				if (sumOfDigits % 8 == 0)
				{
					isDevisibleByEight = true;
				}
				else
				{

					continue;
				}

				for (int j = 0; j < numberAsString.Length; j++)
				{
					digit = int.Parse(numberAsString[j].ToString());

					if (digit % 2 != 0)
					{
						isSomeDigitOdd = true;
						break;
					}
				}
				if (isDevisibleByEight && isSomeDigitOdd)
				{


					Console.WriteLine(number);
				}


			}
		}
	}
}
