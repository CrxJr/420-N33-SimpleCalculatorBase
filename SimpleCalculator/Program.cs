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
            Console.WriteLine("Welcome to Calculator V1.05!");
            bool EndProg = false;
            int numOfInput = 0;
            String choice;
            while (EndProg == false)
            {
                numOfInput++;
                if (numOfInput == 1)
                {
                    Console.WriteLine("Please make your first desired operation");
                    Console.WriteLine("Tips: #1 is the height and #2 is the base when using the triangle area calculator!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Number of operation: " + numOfInput);
                    Console.WriteLine("");
                }
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
                        "\nIf you're unsure of which operation to use enter '' or 'Help'");
                    string operation = Console.ReadLine();

                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                    //Program send the table of elements to show the user all the operations available
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
                    //Here, if the chosen operation is the area of triangle calculator, it will display another text instead of the normal one. It is easier for the user to understand what did happen!
                    if (operation == "t")
                    {
                        sb.Append("The area of the triangle with and height (H) of " + firstNumber + " and a base (B) of " + secondNumber + " is equal to " + Math.Round(result, 2));
                    }
                    else
                    {
                        sb.Append("The value " + firstNumber + " " + operation + " " + secondNumber + " is equal to " + Math.Round(result, 2));
                    }

                    Console.WriteLine(sb.ToString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Thank you for using Calculator V1.05!");
                Console.WriteLine("Y/N End program?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    continue;
                }
                if (choice.ToLower() == "y")
                {
                    Console.WriteLine("Farewell kind user!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter Y or N. Thank you!");
                    choice = Console.ReadLine();
                    continue;
                }

            }
        }
    }
}
