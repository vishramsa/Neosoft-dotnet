// predefined namespace
using System;

// custom namespace
// Namespace consists of types (class, interface, delegates, enum, structs)
namespace HelloWorld
{
    class Program // types consists of type members (variables, data, methods, events, properties)
    {
        static void Main() // starting execution point
        {
            /*Console.Write("Please enter a number : ");
            int n=int.Parse(Console.ReadLine());
            Console.Write($"\nThe factorial of {n} is {Coding.GetFactorial_Recursive(n)}");*/

            /*Console.WriteLine("-------Welcome to my coffee shop------------");
            Console.Write("Please make your Selection.\nPress<1> for small\nPress<2>Medium\n<Press<3> for large\n");
            string choice = Console.ReadLine();
            CoffeeMachine.GetCoffee(choice);*/

            //Arrays.SingleDimensionArray();
            //Arrays.MultiDimensionalArray();
            Arrays.JaggedArrays();
        }
    }
}
