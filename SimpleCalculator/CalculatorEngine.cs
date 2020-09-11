using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;

            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                //Here is the area of triangle calculator using the formula H*B/2
                case "triangle":
                case "t":
                    Console.WriteLine("First number is H and second number is B");
                    result = (argFirstNumber * argSecondNumber) / 2;
                    break;
            
                /* case "^":
                 case "exponent":
                     if (argSecondNumber > 1)
                     {
                         for (int i = 0; i < argSecondNumber; i++)
                         {
                             result = argFirstNumber * argFirstNumber;
                         }
                     }
                     else if (argSecondNumber == 1)
                     {
                         result = argFirstNumber;
                     }
                     else
                     {
                         result = 1;
                     }
                         break;*/
                case "":
                case "help":
                    Console.WriteLine("Please enter one of the following operation: \n+ : add \n- : substract \n/ : divide \n* : multiply\n t: Area of Triangle ");
                    result = 0;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }
            return result;
        }
    }
}
