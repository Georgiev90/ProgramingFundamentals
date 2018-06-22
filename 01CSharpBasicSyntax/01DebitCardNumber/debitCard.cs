using System;

namespace _01DebitCardNumber
{
    class debitCard
    {
        static void Main(string[] args)
        {
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int forthNumber = int.Parse(Console.ReadLine());

			string debitCardNumber = $"{firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {forthNumber:d4}";
			Console.WriteLine(debitCardNumber);
		}
    }
}
