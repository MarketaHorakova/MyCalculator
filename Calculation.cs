using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculation
    {
        //Vlastnosti/Data

        //Metody/Operations
        public double Calculate(double number1, double number2, string chosenOperator)
        {
            switch (chosenOperator)
            {
                case "+": // Sum
                    return number1 + number2;
                case "-": // Subtract
                    return number1 - number2;
                case "*": // Multiple
                    return number1 * number2;
                case "/": // Divide
                    return number1 / number2;
                case "00":
                    return 0;
                default:    // neni potreba
                    Console.WriteLine("I can't calculate with your operator.");
                    return 0; 
            }
        }

    }

}
