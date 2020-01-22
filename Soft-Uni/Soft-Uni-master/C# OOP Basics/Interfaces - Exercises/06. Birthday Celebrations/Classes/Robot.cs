using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Robot:IEntree
    {
    private string id;
    const string birthdate = "0";

    public Robot(string name, string id)
    {
        this.Name = name;
        this.ID = id;
        this.Birthdate = birthdate;
        
    }

    public string Name { get; set; }
    public string ID { get; set; }
    public string Birthdate { get; set; }
    }

