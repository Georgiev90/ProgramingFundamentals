using System;

namespace _07CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
			string ingredient = "";
			int count = 0;
			bool adding = true;
			while (adding) {
				ingredient = Console.ReadLine();
				if (ingredient == "Bake!")
				{
					adding = false;
			
				}
				else
				{
					Console.WriteLine($"Adding ingredient {ingredient}.");
					count++;

				}
				
			}
			Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
