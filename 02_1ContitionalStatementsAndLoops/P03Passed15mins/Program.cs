﻿using System;

namespace P03Passed15mins
{
    class Program
    {
        static void Main(string[] args)
        {
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			minutes += 30;

			if (minutes > 59)
			{
				minutes -= 60;
				hours++;
				if (hours == 24)
				{
					hours = 0;
				}
			}
			Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
