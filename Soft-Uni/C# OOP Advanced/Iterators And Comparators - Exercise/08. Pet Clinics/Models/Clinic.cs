﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Clinic
{
    public Clinic(string name, int roomCount)
    {
        if (roomCount % 2 == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        this.Name = name;
        this.Rooms = new Room[roomCount];
        for (var i = 0; i < this.Rooms.Length; i++)
        {
            this.Rooms[i] = new Room();
        }
    }

    public string Name { get; }

    private Room[] Rooms { get; set; }

    public bool Add(Pet pet)
    {
        var centerId = ((int)Math.Ceiling(this.Rooms.Length / (double)2)) - 1;

        if (!this.HasEmptyRooms())
        {
            return false;
        }

        var steps = 1;
        var i = centerId;
        for (var j = 0; j < this.Rooms.Length; j++)
        {
            if (this.Rooms[i].SickPet is null)
            {
                this.Rooms[i].SickPet = pet;
                return true;
            }

            if (i >= centerId)
            {
                i = centerId - steps;
            }
            else
            {
                i = centerId + steps;
                steps++;
            }
        }

        return false;
    }

    public bool Release()
    {
        var centerId = ((int)Math.Ceiling(this.Rooms.Length / (double)2)) - 1;

        for (var i = centerId; i < this.Rooms.Length; i++)
        {
            if (this.Rooms[i].SickPet != null)
            {
                this.Rooms[i].SickPet = null;
                return true;
            }
        }

        for (var i = 0; i < centerId; i++)
        {
            if (this.Rooms[i].SickPet != null)
            {
                this.Rooms[i].SickPet = null;
                return true;
            }
        }

        return false;
    }

    public bool HasEmptyRooms()
    {
        return this.Rooms.Any(r => r.SickPet is null);
    }

    public void Print()
    {
        Console.WriteLine(string.Join(Environment.NewLine, this.Rooms.ToList()));
    }

    public void Print(int roomId)
    {
        Console.WriteLine(this.Rooms[roomId - 1].ToString());
    }
}

