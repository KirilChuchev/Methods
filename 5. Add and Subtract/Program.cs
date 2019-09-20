using System;

namespace _5._Add_and_Subtract
{
	class Program
	{
		static int SumFirstTwoNumbersFromThreeNumbersFromConsole(int firstNumber, int secondNumber, int thirdNumber)
		{
			int sum = firstNumber + secondNumber;

			return sum;
		}

		static int Subtract(int sum, int thirdNumber)
		{
			int subtract = sum - thirdNumber;

			return subtract;
		}

		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());

			Console.WriteLine(Subtract(SumFirstTwoNumbersFromThreeNumbersFromConsole(firstNumber, secondNumber, thirdNumber), thirdNumber)); 

		}

		
	}
}
