using System;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input two numbers");
                // Class to convert user input
                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Your first number is: " + firstNumber+"\n");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.Write("Your second number is: " + secondNumber+"\n");
                Console.WriteLine("Please input an operator (+, -, *, /)");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                StringBuilder resultBuilder = new StringBuilder();
                resultBuilder.AppendFormat("The value {0:0.00} {1} {2:0.00} is equal to {3:0.00}.",firstNumber,operation,secondNumber,result);

                Console.WriteLine(resultBuilder.ToString());

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
