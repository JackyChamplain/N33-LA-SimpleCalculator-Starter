using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            switch (argOperation.ToLower()) {
                case "+":
                case "addition":
                case "plus":
                case "add":
                case "give":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "-":
                case "subtraction":
                case "minus":
                case "sub":
                case "cut":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "*":
                case "multiplication":
                case "multiply":
                case "mul":
                case "produce":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "/":
                case "division":
                case "divide":
                case "div":
                case "share":
                    if (argSecondNumber > 0)
                        result = argFirstNumber / argSecondNumber;
                    else
                        Console.WriteLine("Error: Second number must be greater than 0");
                    break;
                case "%":
                case "modulus":
                    if (argSecondNumber > 0)
                        result = argFirstNumber % argSecondNumber;
                    else
                        Console.WriteLine("Error: Second number must be greater than 0");
                    break;
                case "^":
                case "exponent":
                case "power":
                case "exp":
                case "pow":
                    result = Math.Pow(argFirstNumber,argSecondNumber);
                    break;
                case "<":
                case "square root":
                case "squrt":
                    Console.WriteLine("Only your first number will be used");
                    result = Math.Sqrt(argFirstNumber);
                    break;

            }



            return result;
        }
    }
}
