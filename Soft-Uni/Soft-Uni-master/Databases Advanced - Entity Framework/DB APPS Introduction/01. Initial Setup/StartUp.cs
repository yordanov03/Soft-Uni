﻿using System;
using System.Data.SqlClient;

public class StartUp
{
    public static void Main(string[] args)
    {
        var connectionString = @"Server=BG5CG5355Y94\SQLEXPRESS01;Integrated Security=True";
        var connection = new SqlConnection(connectionString);

        using (connection)
        {
            connection.Open();
            string databaseSql = "CREATE DATABASE MinionsDB";
            ExecuteNonQuery(connection, databaseSql);
            connection.ChangeDatabase("MinionsDB");

            string tableCountries = "CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50))";
            string tableTowns = "CREATE TABLE Towns(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50), CountryCode INT FOREIGN KEY REFERENCES Countries(Id))";
            string tableMinions = "CREATE TABLE Minions(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(30), Age INT, TownId INT FOREIGN KEY REFERENCES Towns(Id))";
            string tableEvilnessFactor = "CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50))";
            string tableVillians = "CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))";
            string tableMinionsVillians = "CREATE TABLE MinionsVillains(MinionId INT FOREIGN KEY REFERENCES Minions(Id), VillainId INT FOREIGN KEY REFERENCES Villains(Id), CONSTRAINT PK_MinionsVillains PRIMARY KEY (MinionId, VillainId))";
            
            ExecuteNonQuery(connection, tableCountries);
            ExecuteNonQuery(connection, tableTowns);
            ExecuteNonQuery(connection, tableMinions);
            ExecuteNonQuery(connection, tableEvilnessFactor);
            ExecuteNonQuery(connection, tableVillians);
            ExecuteNonQuery(connection, tableMinionsVillians);

            string insertIntoCountries = "INSERT INTO Countries ([Name]) VALUES ('Bulgaria'),('England'),('Cyprus'),('Germany'),('Norway')";
            string insterIntoTowns = "INSERT INTO Towns ([Name], CountryCode) VALUES ('Plovdiv', 1),('Varna', 1),('Burgas', 1),('Sofia', 1),('London', 2),('Southampton', 2),('Bath', 2),('Liverpool', 2),('Berlin', 3),('Frankfurt', 3),('Oslo', 4)";
            string intertIntoMinions = "INSERT INTO Minions (Name,Age, TownId) VALUES('Bob', 42, 3),('Kevin', 1, 1),('Bob ', 32, 6),('Simon', 45, 3),('Cathleen', 11, 2),('Carry ', 50, 10),('Becky', 125, 5),('Mars', 21, 1),('Misho', 5, 10),('Zoe', 125, 5),('Json', 21, 1)";
            string insertIntoEvilnessFactor = "INSERT INTO EvilnessFactors (Name) VALUES ('Super good'),('Good'),('Bad'), ('Evil'),('Super evil')";
            string insertIntoVillians = "INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru',2),('Victor',1),('Jilly',3),('Miro',4),('Rosen',5),('Dimityr',1),('Dobromir',2)";
            string insertIntoMinionsVillians = "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (4,2),(1,1),(5,7),(3,5),(2,6),(11,5),(8,4),(9,7),(7,1),(1,3),(7,3),(5,3),(4,3),(1,2),(2,1),(2,7)";

            ExecuteNonQuery(connection, insertIntoCountries);
            ExecuteNonQuery(connection, insterIntoTowns);
            ExecuteNonQuery(connection, intertIntoMinions);
            ExecuteNonQuery(connection, insertIntoEvilnessFactor);
            ExecuteNonQuery(connection, insertIntoVillians);
            ExecuteNonQuery(connection, insertIntoMinionsVillians);

            connection.Close();
        }

    }

    private static void ExecuteNonQuery(SqlConnection connection, string databaseSql)
    {
        var command = new SqlCommand(databaseSql, connection);

        using (command)
        {
            command.ExecuteNonQuery();
        }
    }
}

