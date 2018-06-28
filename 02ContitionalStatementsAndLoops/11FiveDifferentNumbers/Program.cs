using System;

namespace _11FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int startN = int.Parse(Console.ReadLine());
			int endN = int.Parse(Console.ReadLine());
			if (endN - startN <5) {
				Console.WriteLine("No");
					
			}
			else { 
			for (int d1 = startN; d1 < endN; d1++)
			{
				for (int d2 = startN; d2 < endN; d2++)
				{
					for (int d3 = startN; d3 < endN; d3++)
					{
						for (int d4 = startN; d4 < endN; d4++)
						
							for (int d5 = startN; d5 <= endN; d5++)
							{
									if (startN <= d1 && d1 < d2 && d2 < d3 && d3 < d4 && d4 < d5 && d5 <= endN) {
										Console.WriteLine($"{d1} {d2} {d3} {d4} {d5}");
									}
							}
						}
					}
				}
			}
        }
    }

}