using System;

namespace _12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int firstD = int.Parse(Console.ReadLine());
			int secD = int.Parse(Console.ReadLine());
			int maxSum = int.Parse(Console.ReadLine());
			int currSum = 0;
			int combinationNumb = 0;

			for (int n = firstD; n >= 1; n--)
			{
				for (int m = 1; m <= secD; m++)
				{
					if (currSum < maxSum) {
						currSum += n * m * 3;
						combinationNumb++;
					}
				}
			}
			if (currSum >= maxSum)
			{
				Console.WriteLine($"{combinationNumb} combinations\nSum: {currSum} >= {maxSum}");
			}
			else {
				Console.WriteLine($"{combinationNumb} combinations\nSum: {currSum}");

			}

        }
    }
}
