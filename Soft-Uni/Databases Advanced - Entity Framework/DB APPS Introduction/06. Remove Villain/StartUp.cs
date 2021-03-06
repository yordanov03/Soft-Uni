﻿using System;
using System.Data.SqlClient;

class StartUp
{
    static void Main(string[] args)
    {
        int villianId = int.Parse(Console.ReadLine());
        var connectionString = @"Server=BG5CG5355Y94\SQLEXPRESS01;Database=MinionsDB;Integrated Security=True";
        var connection = new SqlConnection(connectionString);

        using (connection)
        {
            connection.Open();

            string findVillianName = $"SELECT Name FROM Villains WHERE Id = {villianId}";
            using (SqlCommand command = new SqlCommand(findVillianName, connection))
            {
                command.Parameters.AddWithValue("@villianId", villianId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("No such villain was found.");
                        return;
                    }
                    reader.Read();
                    Console.WriteLine($"{reader[0]} was deleted.");
                }

                command.CommandText = $"DELETE FROM MinionsVillains WHERE VillainId = {villianId}";
                int minionsCount = command.ExecuteNonQuery();
                Console.WriteLine($"{minionsCount} minions were released.");

                command.CommandText = $"DELETE FROM Villains WHERE Id = {villianId}";
                command.ExecuteNonQuery();

            }
            connection.Close();
        }

    }
}

