using System;
using System.Runtime.CompilerServices;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var z = "Hello all";
            Console.WriteLine(z.GetType() == typeof(string));
            float a = 10; // 1 byte number
            // The typeof operator is used to obtain the System.Type object for a type.
            Console.WriteLine(typeof(int));
            //int b = (int)a; // 4 byte number 
            string c = "125";
            //b = int.Parse(c); 
            //b = int.Parse(c);
            //Console.WriteLine(b);

            Pet pet1 = new Pet(); // instantiation of the class which means memory is allocated to this Pet class
            //initialize the values
            Console.Write("Please enter your pet's Id: ");
            pet1.id = int.Parse(Console.ReadLine()); //unboxing
            Console.Write("\nPlease enter your pet's name: ");
            pet1.name =Console.ReadLine();
            Console.Write("\nPlease enter your pet's birthday (yyyy/mm/dd): ");
            pet1.dob = DateTime.Parse(Console.ReadLine());
            Console.Write("\nPlease enter you pet's Gender - press <0> for male and press <1> for female: ");
            byte gender = byte.Parse(Console.ReadLine());
            if (gender == 0)
                pet1.gender = Gender.Male;
            else if (gender == 1)
                pet1.gender = Gender.Female;
            else
                Console.Write("Incorrect gender press <0> for male and press <1> for female");

            Console.Write(pet1.GetDetails());
        }  
    }
}
