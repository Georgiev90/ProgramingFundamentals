using System;

namespace ChooseAdrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = "";
            double price = 0.0;



            if ("Athlete".Equals(profession))
            {
                drink = "Water";
                price = 0.7;

            }
            else if ("Businessman".Equals(profession) ||
               "Businesswoman".Equals(profession))
            {
                drink = "Coffee";
                price = 1.0;

            }
            else if ("SoftUni Student".Equals(profession))
            {
                drink = "Beer";
                price = 1.7;
            }
            else
            {
                drink = "Tea";
                price = 1.2;
            }
            double totalPrice = price * quantity;
            


            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}

