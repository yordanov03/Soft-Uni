using System;
using System.Data.SqlClient;


public class StartUp
{
    public static void Main(string[] args)
    {
        var connectionString = @"Server=BG5CG5355Y94\SQLEXPRESS01;Database=MinionsDB;Integrated Security=True";
        var connection = new SqlConnection(connectionString);

        var minionInput = Console.ReadLine().Split(' ');
        var minionName = minionInput[1];
        var minionAge = int.Parse(minionInput[2]);
        var minionTown = minionInput[3];

        var villianInput = Console.ReadLine().Split();
        var villian = villianInput[1];

        using (connection)
        {
            connection.Open();
            var townId = GetTownId(minionTown, connection);
            var villianId = GetVillianId(villian, connection);
            var minionId = InsertMinionAndGetId(minionName, minionAge, townId, connection);
            AssignMinionToVillain(villianId, minionId, connection);
            Console.WriteLine($"Successfully added {minionName} to be minion of {villian}.");

            connection.Close();
        }
    }

    private static void AssignMinionToVillain(int villianId, int minionId, SqlConnection connection)
    {
        string insertMinionVillain = $"INSERT INTO MinionsVillains VALUES ('{minionId}','{villianId}')";
        var insertCommand = new SqlCommand(insertMinionVillain, connection);

        using (insertCommand)
        {
            insertCommand.ExecuteNonQuery();
        }
        
    }

    private static int InsertMinionAndGetId(string minionName, int minionAge, int townId, SqlConnection connection)
    {
        var insertMinion = $"INSERT INTO Minions VALUES ('{minionName}',{minionAge},{townId})";
        var insertCommand = new SqlCommand(insertMinion, connection);

        using (insertCommand)
        {
            var executedCommand = insertCommand.ExecuteNonQuery();
        }
        
        var minionIdString = $"SELECT Id FROM Minions WHERE [Name] = '{minionName}'";
        var minionIdCommand = new SqlCommand(minionIdString, connection);

        using (minionIdCommand)
        {
            return (int) minionIdCommand.ExecuteScalar();
        }

    }

    private static int GetVillianId(string villian, SqlConnection connection)
    {
        var villianString = $"SELECT Id FROM Villains WHERE [Name] = '{villian}'";
        var villianCommand = new SqlCommand(villianString, connection);
        var executedCommand = villianCommand.ExecuteScalar();

        using (villianCommand)
        {
            if (executedCommand ==null)
            {
                var insertVillian = $"INSERT INTO Villains VALUES('{villian}',4)";
                var insertIntoVillians = new SqlCommand(insertVillian, connection);

                using (insertIntoVillians)
                {
                    insertIntoVillians.ExecuteNonQuery();
                }
                
               Console.WriteLine($"Villain {villian} was added to the database.");
            }

            return (int)executedCommand;
        }
    }

    private static int GetTownId(string minionTown, SqlConnection connection)
    {
        var townString = $"SELECT Id FROM Towns WHERE [Name] = '{minionTown}'";
        var townCommand = new SqlCommand(townString, connection);
        var executedTownCommand = townCommand.ExecuteScalar();

        using (townCommand)
        {

            if (executedTownCommand == null)
            {
                var insertTownString = $"INSERT INTO Towns VALUES ('{minionTown}')";
                var insertTownCommand = new SqlCommand(insertTownString, connection);

                using (insertTownCommand)
                {
                    insertTownCommand.ExecuteNonQuery();
                }
                
                Console.WriteLine($"Town {minionTown} was added to the database.");
            }
            return (int)executedTownCommand;
        }
    }

}

