using System;

namespace _14MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
			char startC = char.Parse(Console.ReadLine());
			char endC = char.Parse(Console.ReadLine());
			char excludedC = char.Parse(Console.ReadLine());
			for (char c1 = startC; c1 <= endC; c1++)
			{
				for (char c2 = startC; c2 <= endC; c2++)
				{
					for (char c3 = startC; c3 <= endC; c3++)
					{
						if (c1 != excludedC && c2 != excludedC && c3 != excludedC)
						{
							Console.Write($"{c1}{c2}{c3} ");
						}


					}
				}
			}
        }
    }
}
