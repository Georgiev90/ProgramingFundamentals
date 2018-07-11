using System;

namespace _00LiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			int num = 0;
			//b/b/b/b/d/d/e/c 
			while (true)
			{
				
				num = int.Parse(Console.ReadLine());
				if (num % 2 == 0)
				{
					Console.WriteLine("Please write an odd number.");
					
				}
				else
				{
					break;
				}
			}
			Console.WriteLine($"The number is: {Math.Abs(num)}");
        }
    }
}
