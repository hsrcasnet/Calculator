using System;

namespace Calculator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter value1: ");
            var value1 = Convert.ToDecimal(System.Console.ReadLine());

            System.Console.Write("Enter value2: ");
            var value2 = Convert.ToDecimal(System.Console.ReadLine());

            var calculatorService = new CalculatorService();
            var sum = calculatorService.Add(value1, value2);
            System.Console.WriteLine($"Sum: {sum}");

            System.Console.ReadKey();
        }
    }
}
