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
        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract (double number1, double number2) 
        {
            return number1 - number2;
        }

        public double Multiple (double number1, double number2)
        {
            return number1 * number2;
        }

        public double Divide (double number1, double number2)
        {
            return number1 / number2;
        }

    }
}
