using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Robot :IEntree
    {
    public Robot(string name, string id)
    {
        this.Name = name;
        this.ID = id;
    }

    public string Name { get; set; }
    public string ID { get; set; }
    }

