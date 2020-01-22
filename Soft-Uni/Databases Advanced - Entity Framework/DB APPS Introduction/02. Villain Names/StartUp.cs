using System;
using System.Data.SqlClient;


public class StartUp
{
    public static void Main(string[] args)
    {
        var connectionString = @"Server=BG5CG5355Y94\SQLEXPRESS01;Database=MinionsDB;Integrated Security=True";
        var connection = new SqlConnection(connectionString);

        using (connection)
        {
            connection.Open();

            var minionsInfoCommand = "SELECT vi.Name, COUNT(mnvi.MinionId) AS MinionsCount FROM Villains AS vi " +
                "FULL OUTER JOIN MinionsVillains AS mnvi ON mnvi.VillainId = vi.Id " +
                "GROUP BY vi.Name HAVING COUNT(mnvi.MinionId) > 3 ORDER BY minionsCount DESC";

            var command = new SqlCommand(minionsInfoCommand, connection);

            using (command)
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} - {reader[1]}");
                }

            }

            connection.Close();
        }
    }
}

