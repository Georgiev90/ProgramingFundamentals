using System;

namespace _15NeighbourWars
{
	class Program
	{
		static void Main(string[] args)
		{
			int PeshoDmg = int.Parse(Console.ReadLine());
			int GoshoDmg = int.Parse(Console.ReadLine());
			int PeshoHp = 100;
			int GoshoHp = 100;
			int atackCount = 0;

			while (true)
			{
				atackCount++;
				if (atackCount % 2 != 0)
				{
					if (GoshoHp-PeshoDmg<=0)
					{
						Console.WriteLine($"Pesho won in {atackCount}th round.");
						return;
					}
					else { 
					GoshoHp -= PeshoDmg;
					Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHp} health.");
					}
				}
				else if (atackCount % 2 == 0)
				{
					if (PeshoHp-GoshoDmg <= 0)
					{
						Console.WriteLine($"Gosho won in {atackCount}th round.");
						return;
					}
					else { 
					PeshoHp -= GoshoDmg;
					Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHp} health.");
					}
				}
				if (atackCount % 3 == 0)
				{
					GoshoHp += 10;
					PeshoHp += 10;
				}
			}
		}

	}
}



