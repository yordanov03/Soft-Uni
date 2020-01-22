using System;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;


public class StartUp
{
    public static void Main(string[] args)
    {
        var connectionString = @"Server=BG5CG5355Y94\SQLEXPRESS01;Database=MinionsDB;Integrated Security=True";
        var connection = new SqlConnection(connectionString);
        string countryName = Console.ReadLine();
        var allTowns = new List<string>();

        using (connection)
        {
            connection.Open();
            var selectString = $"SELECT t.Name FROM Towns AS t JOIN Countries AS c ON c.Id = t.CountryCode WHERE c.Name = '{countryName}'";
            var selectTownsCommand = new SqlCommand(selectString, connection);

            using (selectTownsCommand)
            {
                SqlDataReader reader = selectTownsCommand.ExecuteReader();

                while (reader.Read())
                {
                   allTowns.Add(reader[0].ToString().ToUpper());
                }
            }

            if (allTowns.Count == 0)
            {
                Console.WriteLine("No town names were affected.");
            }
            else
            {
                Console.WriteLine($"{allTowns.Count} towns names were affected.\n[{string.Join(", ",allTowns)}]");
            }
           connection.Close();
        }


        
    }
}

