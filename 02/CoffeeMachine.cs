using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class CoffeeMachine
    {
        internal static void getCoffee(string Selection,int quantity)
        {
            int cost = 0;
            string size = "";
            switch (Selection)
            {
                case "1":
                    size = "small";
                    cost = cost + (quantity * 25); 
                    break;
                case "2":
                    size = "medium";
                    cost = cost + (quantity * 40);
                    break;
                case "3":
                    size = "large";
                    cost = cost + (quantity *60);
                    break;
                default: 
                    Console.WriteLine("Invalid Input");
                    break;
            }
            if(cost != 0)
            {
                Console.WriteLine($"Size = {size} \n Quantity = {quantity} \n Your Total Cost is : Rs. {cost}");
            }
            Console.WriteLine("Thank You !! Have a nice day");
        }
    }
}
