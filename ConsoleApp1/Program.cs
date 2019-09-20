using System;

namespace ConsoleApp1
{
	class Program
	{
		static void PrintMinOfThreeIntegers(int digitOne, int digitTwo, int digitThree)
		{
			int digitsMin = int.MaxValue;

			for (int i = 0; i < 3; i++)
			{
				if (digitOne <= digitsMin)
				{
					digitsMin = digitOne;
				}


				if (digitTwo <= digitsMin)
				{
					digitsMin = digitTwo;
				}


				if (digitThree <= digitsMin)
				{
					digitsMin = digitThree;
				}
			}

			Console.WriteLine(digitsMin);
		}


		static void Main(string[] args)
		{
			int digitOne = int.Parse(Console.ReadLine());
			int digitTwo = int.Parse(Console.ReadLine());
			int digitThree = int.Parse(Console.ReadLine());

			PrintMinOfThreeIntegers(digitOne, digitTwo, digitThree);

			

			
		}
	}
}
