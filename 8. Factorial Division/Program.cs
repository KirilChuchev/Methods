using System;

namespace _8._Factorial_Division
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong firstNumber = ulong.Parse(Console.ReadLine());
			ulong secondNumber = ulong.Parse(Console.ReadLine());

			if (firstNumber > 0 && secondNumber > 0)
			{
				FactorielDevisionOfTwoNumbers(firstNumber, secondNumber);
			}
			
		}

		static void FactorielDevisionOfTwoNumbers(ulong firstNumber, ulong secondNumber)
		{
			ulong firstFactoriel = 1;
			ulong secondFactoriel = 1;

			for (ulong i = 1; i <= firstNumber; i++)
			{
				firstFactoriel *= i;
			}

			for (ulong i = 1; i <= secondNumber; i++)
			{
				secondFactoriel *= i;
			}


			decimal devision = firstFactoriel * 1.0M / secondFactoriel;

			
		

			Console.WriteLine($"{devision:F2}");
		}
	}
}
