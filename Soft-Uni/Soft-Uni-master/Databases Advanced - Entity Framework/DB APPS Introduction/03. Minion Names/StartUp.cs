using System;
using System.Data.SqlClient;


public class StartUp
{
    public static void Main(string[] args)
    {
        var connectionString = @"Server=BG5CG5355Y94\SQLEXPRESS01;Database=MinionsDB;Integrated Security=True";
        var connection = new SqlConnection(connectionString);
        var villianId = int.Parse(Console.ReadLine());

        using (connection)
        {
            connection.Open();

            var commandStringMinions = $"SELECT mn.Name, mn.Age " +
                $"FROM Minions AS mn " +
                $"JOIN MinionsVillains AS mv ON mv.MinionId = mn.Id " +
                $"WHERE mv.VillainId= {villianId}";

            var commandStringVillian = $"SELECT [Name] FROM Villains WHERE Id = {villianId}";

            var command = new SqlCommand(commandStringVillian, connection);
            var villianName = command.ExecuteScalar();

            if (villianName == null)
            {
                Console.WriteLine($"No villain with ID {villianId} exists in the database.");
                return;
            }

            else
            {
                using (command)
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"Villian: {reader[0]}");
                    }

                    reader.Close();
                }
            }

            var secondCommand = new SqlCommand(commandStringMinions, connection);
            var secondReader = secondCommand.ExecuteReader();

            if (!secondReader.HasRows)
            {
                Console.WriteLine("(no minions)");
            }

            else
            {
                using (secondCommand)
                {
                    
                    int counter = 1;
                    while (secondReader.Read())
                    {
                        Console.WriteLine($"{counter}. {secondReader[0]} {secondReader[1]}");
                        counter++;
                    }
                }
            }

            connection.Close();
        }
    }
}

