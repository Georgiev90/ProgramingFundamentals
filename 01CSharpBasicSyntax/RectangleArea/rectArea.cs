    using System;

    namespace RectangleArea
    {
        class rectArea
        {
            static void Main(string[] args)
            {
                double sizeA = double.Parse(Console.ReadLine());
                double sizeB = double.Parse(Console.ReadLine());
                double Area = sizeA * sizeB;
                Console.WriteLine($"{Area:F2}");
            }
        }
    }
