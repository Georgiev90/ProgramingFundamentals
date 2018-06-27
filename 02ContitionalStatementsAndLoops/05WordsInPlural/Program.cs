using System;

namespace _05WordsInPlural
{
	class Program
	{
		static void Main(string[] args)
		{
			string noun = Console.ReadLine();

			if (noun.EndsWith('y'))
			{
				noun = noun.Remove(noun.Length - 1, 1) + "ies";
			}
			else if ((noun.EndsWith('o')) || noun.EndsWith('o') || noun.EndsWith('c')
			   || noun.EndsWith('h') || noun.EndsWith('s')
			   || noun.EndsWith("sh") || noun.EndsWith('x')
			   || noun.EndsWith('z'))
			{
				noun += "es";
			}
			else
			{
				noun += "s";
			}
			Console.WriteLine(noun);
		}

	}
}



