using System;

namespace _13GameNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int startN = int.Parse(Console.ReadLine());
			int endN = int.Parse(Console.ReadLine());
			int magicNumb = int.Parse(Console.ReadLine());
			int validN1 = 0;
			int validN2 = 0;
			int combinations = 0;
			bool foundValid = false;

			for (int d1 = startN; d1 <= endN; d1++)
			{
				for (int d2 = startN; d2 <= endN; d2++)
				{
					combinations++;
					if ((d1 + d2) == magicNumb)
					{
						validN1 = d1;
						validN2 = d2;
						foundValid = true;
					}
				}
			}
			if (foundValid)
			{
				Console.WriteLine($"Number found! {validN1} + { validN2} = { magicNumb}");
			}
			else
			{
				Console.WriteLine($"{combinations} combinations - neither equals {magicNumb}");
			}
        }
    }
}
