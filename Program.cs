using System;
using Microsoft.Data.SqlClient;

namespace Adoproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            update();
        }

        static void update()
        {
            string ConnectionString = "Data Source=LAPTOP-8GSJ41FL\\SQLEXPRESS;Initial Catalog=HamroStoreDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Products SET Description='Latest Model 2024', Name='Iphone' WHERE Id='1'", con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Update Successful...");
                }
                else
                {
                    Console.WriteLine("No rows were updated. Check the WHERE condition.");
                }
            }   
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
