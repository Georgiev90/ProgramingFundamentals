using System;

namespace _05CharacterStars
{
    class charStars
    {
        static void Main(string[] args)
        {
			string charName = Console.ReadLine();
			int currentHP = int.Parse(Console.ReadLine());
			int totalHP = int.Parse(Console.ReadLine());
			int currentNRG = int.Parse(Console.ReadLine());
			int totalNRG = int.Parse(Console.ReadLine());

			string hpBar = "|" + new string('|', currentHP)
				+ new string('.', totalHP - currentHP) + "|";
			string energyBar = "|" + new string('|', currentNRG)
				+ new string('.', totalNRG - currentNRG) + "|";

			Console.WriteLine("Name: " + charName);
			Console.WriteLine("Health: " + hpBar);
			Console.WriteLine("Energy: " + energyBar);

		}
	}
}
