using System;
using System.Linq;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{

			//int n = int.Parse(Console.ReadLine());

			string input = Console.ReadLine();



			string[] myArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


			//myArray = myArray.OrderByDescending(x => x[1]).ToArray();

			Array.Sort(myArray);

			Console.WriteLine(string.Join(' ', myArray));

			

		}
	}
}
