using System;

namespace P05ForeignLanguages
{
	class Program
	{
		static void Main(string[] args)
		{
			string country = Console.ReadLine();
			switch (country)
			{
				case "USA":

				case "Canada":

				case "England":
					Console.WriteLine("English");
					break;

				case "Spain":

				case "Argentina":

				case "Mexico": Console.WriteLine("Spanish");
					break;

				case "Portugal":

				case "Brasil": Console.WriteLine("Portuguese");
					break;

				default:
					Console.WriteLine("unknown");
					break;

				 
			}
		}
	}
}
