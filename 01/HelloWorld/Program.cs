// predefined namespace
using System;
using System.Text;

// custom namespace
// Namespace consists of types (class, interface, delegates, enum, structs)
namespace HelloWorld
{
    class Program // types consists of type members (variables, data, methods, events, properties)
    {
        static void Main() // starting execution point
        {
            /*Console.Write("Please enter a number : ");
            int n=int.Parse(Console.ReadLine());*/
            // Passing a value type 
            //int a=4;
            //System.Console.WriteLine(a);
            //Console.Write($"\nThe factorial of {a} is {Coding.GetFactorial(ref a)} \n");// psssing value type as in form of pass by reference
            //System.Console.WriteLine(a);

            //Console.WriteLine("-------Welcome to my coffee shop------------");
            //Console.Write("Please make your Selection.\nPress<1> for small\nPress<2>Medium\n<Press<3> for large\n");
            //string choice = Console.ReadLine();
            //CoffeeMachine.GetCoffee(choice);
            CoffeeMachine.GetCoffee(selection:"2"); // named parameters
            //Arrays.SingleDimensionArray();
            //Arrays.MultiDimensionalArray();
            //Arrays.JaggedArrays();

            // Strings
            //LearnStrings.GetStrings();
            //System.Console.Write("please enter a string to be reversed ");
            //string input=Console.ReadLine();
            
            // Pass By reference
            /*
            StringBuilder str = new StringBuilder("Palindrome");
            LearnStrings.PrintBackwards(str);
            System.Console.WriteLine(str.ToString());*/
            //TestSample();


        }
        static void TestSample(){
            Sample sample=new Sample();
            sample.i=5;
            ModifySample(sample);
            System.Console.WriteLine(sample.i);
        }
        static void ModifySample(Sample obj){
            obj.i=10;
        }
    }
    class Sample{
        public int i;
    }
}
