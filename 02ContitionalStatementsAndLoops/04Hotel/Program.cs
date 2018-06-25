using System;

namespace _04Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			int nightsCount = int.Parse(Console.ReadLine());
			double studio = 0.0;
			double Double = 0.0;
			double suite = 0.0;


			if ("May" == month || "October" == month)
			{

				studio = 50;
				Double = 65;
				suite = 75;

				if (nightsCount > 7)
				{
					studio *= 0.95;

				}

			}
			else if ("June" == month || "September" == month)
			{
				studio = 60;
				Double = 72;
				suite = 82;
				if (nightsCount > 14)
				{
					Double *= 0.9;
				}

			}
			else if ("July" == month || "August" == month || "December" == month)
			{
				studio = 68;
				Double = 77;
				suite = 89;
				if (nightsCount > 14)
				{
					suite *= 0.85;
				}
			}

			double endPriceStudio = studio * nightsCount;
			double endPriceDouble = Double * nightsCount;
			double endPriceSuite = suite * nightsCount;

			if ((month == "September" || month == "October") && nightsCount > 7)
			{
				endPriceStudio -= studio;
			}

			Console.WriteLine($"Studio: {endPriceStudio:f2} lv.");
			Console.WriteLine($"Double: {endPriceDouble:f2} lv.");
			Console.WriteLine($"Suite: {endPriceSuite:f2} lv.");




		}
	}
}
