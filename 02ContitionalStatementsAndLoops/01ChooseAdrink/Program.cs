using System;

namespace ChooseAdrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink = "";
        

            if ("Athlete".Equals(profession))
            {
                drink = "Water";
            }
            else if ("Businessman".Equals(profession) ||
               "Businesswoman".Equals(profession))
            {
                drink = "Coffee";

            }
            else if ("SoftUni Student".Equals(profession))
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }


            Console.WriteLine(drink);
        }
    }
}

