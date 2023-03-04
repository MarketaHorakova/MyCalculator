using System;

namespace MyCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in my computing world.\nMy computing operation are +, -, *, /.");

            while (true)
            {
                double number1 = 0;
                double number2 = 0;
                double myResult = 0;

                // Input number1.
                Console.WriteLine("Please, give me your first number");
                while (!(double.TryParse(Console.ReadLine(), out number1)))
                {
                    Console.WriteLine("I couldn't compute with your number, sorry.");
                }

                while (true)
                {
                    // Choosing operation and check operator.
                    Console.WriteLine("Which operator do you want to use (+, -, *, /, 00 for reset, Q for Quit)?");
                    string chosenOperator = Console.ReadLine();
                    while (!((chosenOperator == "+") || (chosenOperator == "-") || (chosenOperator == "*") || (chosenOperator == "/") || (chosenOperator == "00") || (chosenOperator == "q") || (chosenOperator == "Q")))
                    {
                        Console.WriteLine("Which operator do you want to use (+, -, *, /, 00 for reset, Q for Quit)?");
                        chosenOperator = Console.ReadLine();
                    }

                    // Quit and reset without second number.
                    if (chosenOperator == "Q" || chosenOperator == "q")
                    {
                        Console.WriteLine("Quit");
                        Console.ReadLine();
                        return;
                    }
                    else if (chosenOperator == "00")
                    {
                        myResult = 0;
                        Console.WriteLine($"Reset the calculator.");
                        break;
                    }

                    // Input number 2. Check dividing 0.
                    Console.WriteLine("Now I need your another number.");
                    while (!(double.TryParse(Console.ReadLine(), out number2)) || (chosenOperator == "/" && number2 == 0))
                    {
                        Console.WriteLine("I couldn't compute your number, sorry");
                    }


                    OperatorSwitch actualCalculation = new OperatorSwitch();
                    myResult = actualCalculation.Calculate(number1, number2, chosenOperator);
                    

                    // Vypis vypoctu na konzoli.
                    Console.WriteLine($"My result: {number1} {chosenOperator} {number2} = {myResult}");
                    number1 = myResult;
                }
            }
        }
    }
}

