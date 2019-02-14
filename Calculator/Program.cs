using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            int result = 0;

            // Create a simple calculator that asks the user to input two different numbers 
            Console.Write("Enter a number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a different number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            // and whether they want to add, subtract, multiply or divide them. 
            Console.Write("Would you like to add, subtract, multiply or divide these two numbers? ");
            string mathType = Console.ReadLine();

            if (mathType.ToLower() == "add")
                result = firstNumber + secondNumber;
            if (mathType.ToLower() == "subtract")
                result = firstNumber - secondNumber;
            if (mathType.ToLower() == "multiply")
                result = firstNumber * secondNumber;
            if (mathType.ToLower() == "divide")
                result = firstNumber / secondNumber;

            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }
    }
}
