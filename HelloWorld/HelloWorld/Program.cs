using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number to calculate the factorial of numnber");
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //if (Factorial.calculateFactorialUsingRecursion(userInput) == 0) Console.WriteLine("Invalid Input");
            //else Console.WriteLine("Calculating Factorial using Recursive : = " + Factorial.calculateFactorialUsingRecursion(userInput));
            //if (Factorial.calculateFactorialUsingForLoop(userInput) == 0) Console.WriteLine("Invalid Input");
            //else Console.WriteLine("Calculating Factorial using For Loop : = " + Factorial.calculateFactorialUsingForLoop(userInput));
            //----------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("---------------------Welcome to Cafe Coffee Day---------------------");
            //Console.WriteLine("Small Coffee  Rs.25 \nMedium Coffee Rs.40 \nLargeCoffee Rs.60");
            //Console.WriteLine("Press <1> for small coffee \nPress <2> for medium coffee \nPress <3> for large coffee");
            //Console.WriteLine("Enter your selection");
            //string userSelection=Console.ReadLine();
            //Console.WriteLine("Enter the Quantity : ");
            //int quantity=Convert.ToInt32(Console.ReadLine());
            //CoffeeMachine.getCoffee(userSelection, quantity);
            //----------------------------------------------Calculating FizzBuzz Program------------------------------------------------------------------------------------------------
            FizzBuzz.fizzBuzz();

            /* Calculating Positive integer prime number*/
            /*  getUserInput:
              Console.WriteLine("Enter Number");
              int number = int.Parse(Console.ReadLine());
              if(number < 0)
              {
                  Console.WriteLine("Invalid Input");
                  goto getUserInput;
              }
              positiveIntegerPrimeNumber.checkPrimeNumber(number);*/
        }
    }
}
