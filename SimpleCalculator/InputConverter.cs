using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;

            while (!double.TryParse(argTextInput, out convertedNumber))
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number:");
                argTextInput = Console.ReadLine();
            }
            return convertedNumber;
        }
    }
}
