using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class CoffeeMachine
    {
        internal static void GetCoffee(string selection)
        {
            int cost = 0;
            switch (selection)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    goto case "1";
                case "3":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            if(cost != 0)
            {
                Console.WriteLine($"Your total amount is Rs. {cost}");
            }
            Console.Write("Thank you for the business and have a nice day!");
        }
    }
}
