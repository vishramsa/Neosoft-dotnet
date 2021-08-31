using System;
using System.Data;
using System.Data.SqlClient;

namespace PetDataADO
{
    public class ConnectedArchitecture
    {
        public static void GetAllCats(string conString, string query, out SqlConnection connection, out SqlCommand command, out SqlDataReader reader)
        {
            using (connection=new SqlConnection(conString)) // opens the connection with Sql database
            {
                try
                {
                    connection.Open();
                    using (command = new SqlCommand(query, connection))
                    {
                        reader=command.ExecuteReader();// this command will exceute the command and return the values
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader[0]} - {reader["Name"]}");
                            }
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                    //log errors
                }
                finally {
                    connection.Close();
                }
               
            }
        }
    }
}
