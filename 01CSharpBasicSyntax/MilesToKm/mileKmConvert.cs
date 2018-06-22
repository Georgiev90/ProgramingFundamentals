using System;

namespace MilesToKm
{
    class mileKmConvert
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double ratio = 1.60934;
            double km = miles * ratio;

            Console.WriteLine($"{km:F2}");
        }
    }
}
