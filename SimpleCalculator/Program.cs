using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Please enter the first number");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
               
                Console.WriteLine("Please enter the second number");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Please enter your desire operation " +
                    "\nIf you're unusre of which operation to use enter '' or 'Help'");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                if (result == 0 || operation.ToLower().Equals("help"))
                    operation = Console.ReadLine();

                switch (operation)
                {
                    case "add":
                    case "+":
                        operation = " plus the value ";
                        break;
                    case "substract":
                    case "-":
                        operation = " substracted by the value ";
                        break;
                    case "multiply":
                    case "*":
                        operation = " multiplied by the value ";
                        break;
                    case "divide":
                    case "/":
                        operation = " divided by the value ";
                        break;
                }

                sb.Append("The value " + firstNumber + operation + secondNumber + " is equal to " + Math.Round(result,2));

                Console.WriteLine(sb.ToString());

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
