using System;

namespace COMP2614Assign01
{
	class MyApp
	{
		public const int MAX_VALUE = 20;
		static void Main(string[] args)
		{
			Run();
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine("Thank you. Good bye! [press any key to exit]");
			Console.ReadKey();
		}

		private static void Run()
		{
			string response = String.Empty;

			do
			{
				Console.WriteLine();
				Console.Write("Please, enter value to calculate? [The default value is 20]: ");
				response = Console.ReadLine().ToLower().Trim();

				int max = 0;
				bool value = int.TryParse(response, out max);

				if (!value)
				{
					Console.WriteLine($"The value: \"{response}\" is not a valid value, setting to the default value.");
					max = MAX_VALUE;
				}
				
				Console.WriteLine();

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"{"number",10} {"square",10} {"cube",10}");
				Console.WriteLine("----------------------------------");
				Console.ForegroundColor = ConsoleColor.White;
				int num, numberSum = 0;
				int sqr, squareSum = 0;
				int cub, cubeSum = 0;
				for (int i = 0; i <= max; i += 2)
				{
					num = i;
					numberSum += i;
					sqr = i * i;
					squareSum += sqr;
					cub = i * i * i;
					cubeSum += cub;

					Console.WriteLine($"{num,10:N0} {sqr,10:N0} {cub,10:N0} ");

				}
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("----------------------------------");
				Console.WriteLine($"{numberSum,10:N0} {squareSum,10:N0} {cubeSum,10:N0}");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine();
				Console.Write("Again? [Y/N]: ");
				response = Console.ReadLine();
				if (response.ToLower().Trim().Equals("y"))
				{
					Console.Clear();
				}
			} while (response.ToLower().Trim().Equals("y"));
		}
	}
}
