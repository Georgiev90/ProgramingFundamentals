using System;

namespace _05IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int startNum = int.Parse(Console.ReadLine());
			int endNum = int.Parse(Console.ReadLine());
			if (startNum > endNum) {  
				int max = startNum;
				startNum = endNum;
				endNum = max;
			}
			while (startNum <= endNum)
			{
				Console.WriteLine(startNum);
				startNum++;
			}
        }
    }
}
