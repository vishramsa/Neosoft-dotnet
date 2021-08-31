using System;
using PetLib;
using System.Data;
using System.Data.SqlClient;
using PetDataADO;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args) // entry point
        {

            string conString = "Server=tcp:petdbserver.database.windows.net,1433;Initial Catalog=PetDb;Persist Security Info=False;User ID=dev;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query ="SELECT Id, Name from Cats";
            //1. Make sql connection
            SqlConnection connection;
            //2. Fire Sql Command
            SqlCommand command;
            //3. Execute command and get results
            SqlDataReader reader;
            try
            {
                ConnectedArchitecture.GetAllCats(conString,query,out connection,out command, out reader);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// This function takes input from user and print those details in the formatted way
        /// </summary>
        private static PetLib.Cat AddCat()
        {
            Cat pet1=new Cat();            
            Console.Write("Please enter your pet's Id: ");
            pet1.Id = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter your pet's name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your pet's birthday (yyyy/mm/dd): ");
            pet1.Dob = DateTime.Parse(Console.ReadLine());
            Console.Write("\nPlease enter you pet's Gender - press <0> for male and press <1> for female: ");
            byte gender = byte.Parse(Console.ReadLine());
            if (gender == 0)
                pet1.Gender = Gender.Male;
            else if (gender == 1)
                pet1.Gender = Gender.Female;
            else
                Console.Write("Incorrect gender press <0> for male and press <1> for female");
            Console.Write(" Please enter the weight of your cat in pounds ");
            pet1.Weight=Convert.ToDouble(Console.ReadLine());
            pet1.CatType = CatType.Himalayan;
            return pet1;
        }
    }
}
