using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int hallPrice = 0;
            string hallName = "";
            double discount = 0.0;
            int packagePrice = 0;
            if (groupSize <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            if ("Normal".Equals(package))
            {
                packagePrice = 500;
                discount = 5;
            }
            else if ("Gold".Equals(package))
            {
                packagePrice = 750;
                discount = 10;
            }

            else
            {
                packagePrice = 1000;
                discount = 15;
            }
            double totalDiscount = discount * (hallPrice + packagePrice) / 100.0;
            double totalPrice = hallPrice + packagePrice-totalDiscount;
            double pricePerPerson = totalPrice / groupSize;
           Console.WriteLine($"We can offer you the {hallName}\r\nThe price per person is {pricePerPerson:F2}$");
        }
    }
}

