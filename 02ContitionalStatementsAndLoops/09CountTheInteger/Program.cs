using System;

namespace _09CountTheInteger
{
	class Program
	{
		static void Main(string[] args)
		{
			int integerCount = 0;

		
			try
			{
				while (true) { 
				int input = int.Parse(Console.ReadLine());
				integerCount++;
				}
			}

			catch (Exception)
			{
				Console.WriteLine(integerCount);
			}
		}
	}
}



