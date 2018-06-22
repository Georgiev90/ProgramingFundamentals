using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinkName=Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double totalKcal = volume / 100.0 * energyContent;
            double totalSugar = volume / 100.0 * sugarContent;


            Console.WriteLine($"{volume}ml {drinkName}:\r\n{totalKcal}kcal, {totalSugar}g sugars");
        
        }
    }
}
