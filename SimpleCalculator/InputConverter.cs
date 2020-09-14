using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            
            //This allows the user to re-enter a value if an incorrect value ahs been enter
            if (!double.TryParse(argTextInput, out convertedNumber)){
                Console.WriteLine("Expected a numeric value.");
                convertedNumber = ConvertInputToNumeric(Console.ReadLine());
            }

            return convertedNumber;
        }
    }
}
