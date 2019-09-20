using System;
using System.Linq;

namespace _11._Array_Manipulator
{
	class Program
	{
		static void Exchange(int[] integers, int index)
		{
			if (index >= integers.Length || index < 0)
			{
				Console.WriteLine("Invalid index");
				return;
			}

			int[] tempIntegers = new int[integers.Length - index - 1];
			
			for (int i = 0; i < integers.Length - index - 1; i++)
			{
				tempIntegers[i] = integers[index + 1 + i];
			}

			int k = 0;
			for (int i = index; i >= 0; i--)
			{
				integers[integers.Length - 1 - k] = integers[i];
				k++;
			}

			for (int i = 0; i < tempIntegers.Length; i++)
			{
				integers[i] = tempIntegers[i];
			}

			//Console.WriteLine(string.Join(" ", integers));
		}














		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			int[] integers = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			string commandAsString = string.Empty;

			while ((commandAsString = Console.ReadLine()) != "end")
			{
				string[] command = commandAsString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

				switch (command[0])
				{
					case "exchange":
						{
							int index = int.Parse(command[1]);

							Exchange(integers, index);
						}
						break;
					case "max":
					case "min":
						{
							Print_Index_Of_Min_Max_And_Even_Odd(integers, command);

						}
						break;
					case "first":
						{
							Print_First_N_Numbers_Odd_Or_Even(integers, command);
						}
						break;
					case "last":
						{
							Print_Last_N_Numbers_Odd_Or_Even(integers, command);
						}
						break;

					default:
						break;
				}

				

			}

			string lastArray = string.Join(", ", integers);
			Console.WriteLine($"[{lastArray}]");






		}

		




	private static void Print_Last_N_Numbers_Odd_Or_Even(int[] integers, string[] command)
		{

			if (int.Parse(command[1]) > integers.Length)
			{
				Console.WriteLine("Invalid count");
				return;
			}

			int countEven = 0;
			int countOdd = 0;

			

			for (int i = 0; i < integers.Length; i++)
			{
				if (integers[i] % 2 != 0)
				{
					countOdd++;
				}
				else
				{
					countEven++;
				}
			}




			int[] last = new int[int.Parse(command[1])];
			int counter = -1;

			if (command[2] == "odd")
			{
				last = new int[countOdd];
				counter = 0;

				for (int i = integers.Length - 1; i >= 0; i--)
				{
					if (integers[i] % 2 != 0)
					{
						if (counter <= int.Parse(command[1]) && counter <= countOdd)
						{
							last[counter] = integers[i];
							counter++;
						}
						else
						{
							break;
						}

						
					}

					
				}
			}
			else if (command[2] == "even")
			{

				last = new int[countEven];
				

				for (int i = integers.Length - 1; i >= 0; i--)
				{
					if (integers[i] % 2 == 0)
					{
						if (counter + 1 == int.Parse(command[1]) && counter + 1 >= countOdd)
						{
							break;
						}
						else
						{
							counter++;
							last[counter] = integers[i];
							
						}
					}

					
				}
			}

			if (counter == -1)
			{
				Console.WriteLine("[]");
			}
			else
			{
				Array.Reverse(last);
				
				Console.Write("[");
				for (int i = 0; i < counter - 1; i++)
				{
					Console.Write(last[i] + ", ");
				}
				Console.Write(last[counter - 1]);
				Console.Write("]");
				Console.WriteLine();
			}


		}

		static void Print_First_N_Numbers_Odd_Or_Even(int[] integers, string[] command)
		{
			if (int.Parse(command[1]) > integers.Length)
			{
				Console.WriteLine("Invalid count");
				return;
			}

			int[] first = new int[int.Parse(command[1])];
			int counter = -1;

			if (command[2] == "odd")
			{
				counter = 0;

				for (int i = 0; i < integers.Length; i++)
				{
					if (integers[i] % 2 != 0)
					{
						if (counter == int.Parse(command[1]))
						{
							break;
						}
						else
						{
							first[counter] = integers[i];
							counter++;
						}
					}

					
				}
			}
			else if (command[2] == "even")
			{
				counter = 0;

				for (int i = 0; i < integers.Length; i++)
				{
					if (integers[i] % 2 == 0)
					{
						if (counter == int.Parse(command[1]))
						{
							break;
						}
						else
						{
							first[counter] = integers[i];
							counter++;
						}
					}

					
				}
			}

			if (counter == -1)
			{
				Console.WriteLine("[]");
			}
			else
			{
				
				Console.Write("[");
				for (int i = 0; i < counter - 1; i++)
				{
					Console.Write(first[i] + ", ");
				}
				Console.Write(first[counter - 1]);
				Console.Write("]");
				Console.WriteLine();
			}

			
		}

		static void Print_Index_Of_Min_Max_And_Even_Odd(int[] integers, string[] command)
		{
			


			if (command[0] == "max")
			{
				if (command[1] == "odd")
				{
					int max = int.MinValue;
					int indexMax = -1;

					for (int i = 0; i < integers.Length; i++)
					{

						if ((integers[i] % 2 != 0) && (integers[i] >= max))
						{
							max = integers[i];
							indexMax = i;
						}
					}

					if (indexMax == -1)
					{
						Console.WriteLine("No matches");
					}
					else
					{
						Console.WriteLine(indexMax);
					}
				}
				else
				{
					int max = int.MinValue;
					int indexMax = -1;

					for (int i = 0; i < integers.Length; i++)
					{
						if ((integers[i] % 2 == 0) && (integers[i] >= max))
						{
							max = integers[i];
							indexMax = i;
						}
					}

					if (indexMax == -1)
					{
						Console.WriteLine("No matches");
					}
					else
					{
						Console.WriteLine(indexMax);
					}
				}
			}
			else
			{
				if (command[1] == "odd")
				{
					int min = int.MaxValue;
					int indexMin = -1;

					for (int i = 0; i < integers.Length; i++)
					{

						if ((integers[i] % 2 != 0) && (integers[i] <= min))
						{
							min = integers[i];
							indexMin = i;
						}
					}

					if (indexMin == -1)
					{
						Console.WriteLine("No matches");
					}
					else
					{
						Console.WriteLine(indexMin);
					}
				}
				else
				{
					int min = int.MaxValue;
					int indexMin = -1;

					for (int i = 0; i < integers.Length; i++)
					{
						if ((integers[i] % 2 == 0) && (integers[i] <= min))
						{
							min = integers[i];
							indexMin = i;
						}
					}

					if (indexMin == -1)
					{
						Console.WriteLine("No matches");
					}
					else
					{
						Console.WriteLine(indexMin);
					}
				}
			}
		}
	}
}
