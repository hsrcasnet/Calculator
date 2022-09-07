using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value1: ");
            var value1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter value2: ");
            var value2 = Convert.ToDecimal(Console.ReadLine());

            var calculatorService = new CalculatorService();
            var sum = calculatorService.Add(value1, value2);
            Console.WriteLine($"Sum: {sum}");

            Console.ReadKey();
        }
    }
}
