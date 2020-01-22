﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Citizen:IEntree
    {
    private int age;
    private string id;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.Birthdate = birthdate;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string ID { get; set; }
    public string Birthdate { get; set; }
    }

